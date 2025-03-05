using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltTicket
    {
        public int TicketNumber { get; set; }
        public Vehicle Vehicle { get; set; }
        public StoreBaeltTicket(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }
        public double StoreBaeltCar(Car car)
        {
            double weekenddiscount = 0.85;
            double totalprice = 0;

            if (car.Date.DayOfWeek == DayOfWeek.Saturday
                || car.Date.DayOfWeek == DayOfWeek.Sunday)    
            {
                totalprice += (car.Price() * weekenddiscount);
                return totalprice;
            }
            else
            {
                return totalprice += car.Price();
            }
        }

        public double StoreBaeltMC(MC mC)
        {
            double totalprice = 0;
            totalprice += mC.Price();
            return totalprice;
        }
    }
}
