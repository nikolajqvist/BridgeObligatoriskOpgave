using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oresundbron
{
    public class OresundCar : OreSundVehicle
    {
        public OresundCar(string licensPlate, bool useBrobizz) : base(licensPlate, useBrobizz)
        {
        }
        public override string VehicleType()
        {
            return "Oresund car";
        }
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
