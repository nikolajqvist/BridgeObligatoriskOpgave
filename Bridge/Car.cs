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
        public Car(string licensPlate) : base(licensPlate)
        {
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}
