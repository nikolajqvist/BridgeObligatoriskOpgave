using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace Oresundbron
{
    /// <summary>
    /// Dette er klassen ØresundMC 
    /// </summary>
    public class OresundMC : Vehicle
    {
        /// <summary>
        /// Det her er konstruktøren som beskriver hvordan en ØresundMC ser ud
        /// </summary>
        /// <param name="licensPlate"></param>
        /// <param name="useBrobizz"></param>
        public OresundMC(string licensPlate, bool useBrobizz) : base(licensPlate, useBrobizz)
        {
        }
        /// <summary>
        /// Beskriver typen af køretøj
        /// </summary>
        /// <returns>Retunere en streng med navnet på typen af køretøj</returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }
        /// <summary>
        /// Prisen på en MC over broen
        /// </summary>
        /// <returns>Returnere prisen i en double</returns>
        public override double Price()
        {
            if (UseBrobizz)
            {
                return 92.0;
            }
            else
            {
                return 235.0;
            }
        }
    }
}
