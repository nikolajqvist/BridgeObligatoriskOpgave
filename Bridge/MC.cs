using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class MC: Vehicle
    {
        public MC(string licensPlate, bool useBrobizz) : base(licensPlate, useBrobizz)
        {
        }

        public override double Price()
        {
            if (UseBrobizz)
            {
                return Math.Abs(base.Price() - 110 * 0.9);
            }
            else
            {
                return base.Price() - 110;
            }
        }
        public override string VehicleType()
        {
            return "Motorcycle";
        }
    }
}
