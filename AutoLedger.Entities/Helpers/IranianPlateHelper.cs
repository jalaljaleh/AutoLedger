using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLedger.Entities
{
    public class IranianPlateHelper
    {
        public int ProvinceCode { get; set; } 
        public string Letter { get; set; }   
        public int SerialNumber { get; set; } 
        public int SuffixCode { get; set; }  


        public string FullPlateText
        {
            get
            {
                return $"{ProvinceCode} {Letter} {SerialNumber} {SuffixCode}";
            }
        }
    }
}
