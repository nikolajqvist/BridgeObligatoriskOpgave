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
        public override string VehicleType()
        {
            return "Motorcycle";
        }
    }
}
