using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Dette er klassen MC 
    /// </summary>
    public class MC: Vehicle
    {
        /// <summary>
        /// Det her er konstruktøren som beskriver hvordan en MC ser ud
        /// </summary>
        /// <param name="licensPlate"></param>
        /// <param name="useBrobizz"></param>
        public MC(string licensPlate, bool useBrobizz) : base(licensPlate, useBrobizz)
        {
        }
        /// <summary>
        /// Prisen på en MC over broen
        /// </summary>
        /// <returns>Returnere prisen i en double</returns>
        public override double Price()
        {
            double brobizzdiscount = 0.90;
            if (UseBrobizz)
            {
                return ((base.Price() - 110) * brobizzdiscount);
            }
            else
            {
                return base.Price() - 110;
            }
        }
        /// <summary>
        /// Beskriver typen af køretøj
        /// </summary>
        /// <returns>Retunere en streng med navnet på typen af køretøj</returns>
        public override string VehicleType()
        {
            return "Motorcycle";
        }
    }
}
