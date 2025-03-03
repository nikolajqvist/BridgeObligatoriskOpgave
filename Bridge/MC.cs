using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class MC: Vehicle
    {
        public MC(string licensPlate): base(licensPlate)
        {
        }
        public override double Price()
        {
            return base.Price() - 110;
        }
        public override string VehicleType()
        {
            return "Motorcycle";
        }
    }
}
