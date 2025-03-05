using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Vehicle
    {
        public string LicensPlate {  get; set; }
        //public string LicensPlate { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public bool UseBrobizz {  get; set; }
        public Vehicle(string licensPlate, bool useBrobizz)
        {
            if (licensPlate.Length < 7)
            {
                throw new ArgumentOutOfRangeException("En nummerplade skal være syv tegn langt.");
            }
            if (licensPlate == null)
            {
                throw new ArgumentNullException("Kunne ikke finde nummerpladen");
            }
            LicensPlate = licensPlate;
            UseBrobizz = useBrobizz;
            Date = DateTime.Now;
        }
        public virtual double Price()
        {
            return 230;
        }
        public abstract string VehicleType();
    }
}
