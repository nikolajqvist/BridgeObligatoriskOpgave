using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Car klassen med en price metode
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Car construtor med parametre som den fødes med
        /// </summary>
        /// <param name="licensPlate"></param>
        /// <param name="useBrobizz"></param>
        public Car(string licensPlate, bool useBrobizz) : base(licensPlate, useBrobizz)
        {
        }
        /// <summary>
        /// Price metode til at regne prisen på ud bilens tur over broerne
        /// </summary>
        /// <returns>en double med prisen</returns>
        public override double Price()
        {
            double brobizzdiscount = 0.90;
            if (UseBrobizz)
            {
                return ((base.Price()) * brobizzdiscount);
            }
            else
            {
                return base.Price();
            }
        }
        /// <summary>
        /// Udskriver hvad for et køretøj det er vi har med at gøre.
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
