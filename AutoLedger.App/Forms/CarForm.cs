using AutoLedger.Data;
using AutoLedger.Domain;
using AutoLedger.Extensions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace AutoLedger.App.Forms
{
    public partial class CarForm : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        private Car _car;
        public CarForm(Car car = null)
        {
            InitializeComponent();

            this._car = car;

            // Wire up events for validation / step progress updates
            inputBrand.TextChanged += Inputs_TextChanged;
            inputModel.TextChanged += Inputs_TextChanged;
            inputColor.TextChanged += Inputs_TextChanged;
            inputTip.TextChanged += Inputs_TextChanged;
            inputPhoneNumber.TextChanged += Inputs_TextChanged;
            inputFullName.TextChanged += Inputs_TextChanged;
            inputUserCardId.TextChanged += Inputs_TextChanged;



            this.btnNext.Click += BtnNext_Click;
            this.btnCancel.Click += BtnCancel_Click;


            // Populate fields when editing
            if (_car != null)
            {
                carIdControl.SetOrClearPlate(_car.PlateId);
                inputBrand.Text = _car.Brand;
                inputModel.Text = _car.Model.ToString();
                inputColor.Text = _car.Color;
                inputTip.Text = _car.Tip;
                inputPhoneNumber.Text = _car.OwnerPhoneNumber;
                inputFullName.Text = _car.OwnerFullName;
                inputUserCardId.Text = _car.OwnerNationalId;

                inputCreatedAt.Text = _car.CreatedAt.ToShamsiLong();
                inputId.Text = _car.Id.ToString();
            }
            else
            {
                inputCreatedAt.Text = DateTime.Now.ToShamsiLong();
                inputId.Text = "[شناسه پذیرش]";
            }

            // Initialize step progress bar state
            UpdateStepProgressBar();
        }
        public Car GetCar()
        {
            return _car;
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Inputs_TextChanged(object sender, EventArgs e)
        {
            UpdateStepProgressBar();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {

            // Validate model parsing
            if (!int.TryParse(inputModel.Text.Trim(), out int model))
            {
                MessageBox.Show("Model must be a valid integer.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var plate = carIdControl.GetPlate();
            if (string.IsNullOrWhiteSpace(plate))
            {
                MessageBox.Show("Please enter a valid plate id.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                using (var db = new AutoLedgerContext())
                {
                    if (_car is null) // insert
                    {
                        var newCar = new Car
                        {
                            PlateId = plate,
                            Brand = inputBrand.Text.Trim(),
                            Model = model,
                            Color = inputColor.Text.Trim(),
                            Tip = inputTip.Text.Trim(),
                            OwnerPhoneNumber = inputPhoneNumber.Text.Trim(),
                            OwnerFullName = inputFullName.Text.Trim(),
                            OwnerNationalId = inputUserCardId.Text.Trim(),
                            UpdatedAt = DateTime.Now,
                            Receptions = new List<CarReception>()
                        };

                        db.Cars.Add(newCar);
                        db.SaveChanges();

                        _car = newCar; // keep reference to newly created car
                    }
                    else // update
                    {
                        // Prefer to find by primary key if available, otherwise by plate id
                        Car carToUpdate = null;

                        if (_car.Id > 0)
                        {
                            carToUpdate = db.Cars.SingleOrDefault(c => c.Id == _car.Id);
                        }

                        if (carToUpdate == null)
                        {
                            // fallback to plate id
                            carToUpdate = db.Cars.SingleOrDefault(c => c.PlateId == plate);
                        }

                        if (carToUpdate == null)
                        {
                            MessageBox.Show("Could not find the car to update in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Update fields
                        carToUpdate.PlateId = plate;
                        carToUpdate.Brand = inputBrand.Text.Trim();
                        carToUpdate.Model = model;
                        carToUpdate.Color = inputColor.Text.Trim();
                        carToUpdate.Tip = inputTip.Text.Trim();
                        carToUpdate.OwnerPhoneNumber = inputPhoneNumber.Text.Trim();
                        carToUpdate.OwnerFullName = inputFullName.Text.Trim();
                        carToUpdate.OwnerNationalId = inputUserCardId.Text.Trim();
                        carToUpdate.UpdatedAt = DateTime.Now;

                        // Mark entity as modified and save
                        db.Entry(carToUpdate).State = EntityState.Modified;
                        db.SaveChanges();

                        // Update local reference
                        _car = carToUpdate;
                    }
                }

                // After successful save, refresh step progress bar
                UpdateStepProgressBar();


                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // Log exception as needed
                MessageBox.Show($"An error occurred while saving the car: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Updates the DevExpress StepProgressBar items using integer scores.
        /// btnCarInfo.Progress and btnCarOwnerInfo.Progress are set to the computed scores.
        /// </summary>
        private void UpdateStepProgressBar()
        {

            int carInfoScore = GetCarInfoScore();       // e.g., 0..4
            int ownerInfoScore = GetOwnerInfoScore();   // e.g., 0..3

            btnCarOwnerInfo.Progress = carInfoScore;
            btnNone.Progress = carInfoScore > 70 ? ownerInfoScore : 0;
        }

        /// <summary>
        /// Returns an integer score representing how many car-info fields are valid/filled.
        /// Adjust weights and fields as needed.
        /// Example scoring:
        /// 1 point for plate, 1 for brand, 1 for valid model, 1 for color, 1 for tip (optional).
        /// </summary>
        private int GetCarInfoScore()
        {
            int score = 0;

            // Plate
            var plate = carIdControl.GetPlate();
            if (!string.IsNullOrWhiteSpace(plate)) score++;

            // Brand
            if (!string.IsNullOrWhiteSpace(inputBrand.Text)) score++;

            // Model (must parse to int)
            if (int.TryParse(inputModel.Text.Trim(), out _)) score++;

            // Color
            if (!string.IsNullOrWhiteSpace(inputColor.Text)) score++;

            // Tip (optional) - include if you want it to contribute
            if (!string.IsNullOrWhiteSpace(inputTip.Text)) score++;

            return score * 100 / 5;
        }

        /// <summary>
        /// Returns an integer score representing how many owner-info fields are filled.
        /// Example scoring:
        /// 1 point for full name, 1 for phone, 1 for national id.
        /// </summary>
        private int GetOwnerInfoScore()
        {
            int score = 0;

            if (!string.IsNullOrWhiteSpace(inputFullName.Text)) score++;
            if (!string.IsNullOrWhiteSpace(inputPhoneNumber.Text)) score++;
            if (!string.IsNullOrWhiteSpace(inputUserCardId.Text)) score++;

            return score * 100 / 5;
        }

        public CarForm WithPlateId(string plate)
        {
            this.carIdControl.SetOrClearPlate(plate);
            UpdateStepProgressBar();
            return this;
        }
    }
}
