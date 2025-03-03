using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaelt
    {
        public double WeekendDiscount(DateOnly date, Vehicle vehicle)
        {
            double discount = 0.85;
            double totalPrice = 0;
            if (date.DayOfWeek == DayOfWeek.Saturday && vehicle is Car
                || date.DayOfWeek == DayOfWeek.Sunday && vehicle is Car) 
            {
                totalPrice = Math.Abs(vehicle.Price() * discount);
                return totalPrice;
            }
            return vehicle.Price();
        }
    }
}
