using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oresundbron
{
    public class OresundMC : OreSundVehicle
    {
        public OresundMC(string licensPlate, bool useBrobizz) : base(licensPlate, useBrobizz)
        {
        }
        public override string VehicleType()
        {
            return "Oresund MC";
        }
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
