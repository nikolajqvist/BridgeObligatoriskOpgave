using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Dette er klassen som beskriver hvordan en billet ser ud.
    /// </summary>
    public class StoreBaeltTicket
    {
        /// <summary>
        /// Billet nummeret.
        /// </summary>
        public int TicketNumber { get; set; }
        /// <summary>
        /// Det køretøj der knyttet til biletten
        /// </summary>
        public Vehicle Vehicle { get; set; }
        /// <summary>
        /// Dette er konstruktøren der viser hvordan en billet bliver født.
        /// </summary>
        /// <param name="vehicle"></param>
        public StoreBaeltTicket(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }
        /// <summary>
        /// En metode til at regner prisen ud for en bil der kører over storebælt.
        /// </summary>
        /// <param name="car"></param>
        /// <returns>Retunere en double som er prisen på billetten.</returns>
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

    }
}
