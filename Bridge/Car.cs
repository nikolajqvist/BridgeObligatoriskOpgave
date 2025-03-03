using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Car : Vehicle
    {
        public Car(string licensPlate, bool useBrobizz) : base(licensPlate, useBrobizz)
        {
        }
        public override double Price()
        {
            if (UseBrobizz)
            {
                return Math.Abs(base.Price() * 0.90);
            }
            else
            {
                return base.Price();
            }
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}
