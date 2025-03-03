using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class MC
    {
        public string LicensPlate {  get; set; }
        public DateTime Date {  get; set; } = DateTime.Now;

        public MC(string licensPlate)
        {
            LicensPlate = licensPlate;
        }
        public double Price()
        {
            return 120;
        }
        public string Vehicle()
        {
            return "MC";
        }
    }
}
