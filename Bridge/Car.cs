using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// This is the car class called car.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// This is the licensplate of a car.
        /// </summary>
        public string Licensplate { get; set; }
        /// <summary>
        /// This is the date and time the car is driving across the bridge.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// This is the car constructor
        /// </summary>
        public Car(string licensplate, DateTime date)
        {
            Licensplate = licensplate;
            Date = date;
        }
        public double Price()
        {
            return 230.0;
        }
        public string VehicleType()
        {
            return "Car";
        }
    }
}
