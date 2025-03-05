using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace Oresundbron
{
    public class OreSundVehicle : Vehicle
    {
        public OreSundVehicle(string licensPlate, bool useBrobizz) : base(licensPlate, useBrobizz)
        {
        }

        public override string VehicleType()
        {
            return "Oresund vehicle";
        }
    }
}
