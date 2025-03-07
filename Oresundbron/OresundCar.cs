using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace Oresundbron
{
    /// <summary>
    /// Dette er klassen over en øresundsbil
    /// </summary>
    public class OresundCar : Vehicle
    {
        /// <summary>
        /// Dette er konstruktøren som beskriver hvordan en øresundsbil bliver født
        /// </summary>
        /// <param name="licensPlate"></param>
        /// <param name="useBrobizz"></param>
        public OresundCar(string licensPlate, bool useBrobizz) : base(licensPlate, useBrobizz)
        {
        }
        /// <summary>
        /// Beskriver typen af køretøj
        /// </summary>
        /// <returns>Retunere en streng med navnet på typen af køretøj</returns>
        public override string VehicleType()
        {
            return "Oresund car";
        }
        /// <summary>
        /// Price metode til at regne prisen på ud bilens tur over broerne
        /// </summary>
        /// <returns>Retunere bilens pris i en double</returns>
        public override double Price()
        {
            if (UseBrobizz)
            {
                return 178.0;
            }
            else
            {
                return 460.0;
            }
        }
    }
}
