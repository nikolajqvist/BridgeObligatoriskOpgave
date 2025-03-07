using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// StorebæltRepository over CRUD funktionaliteter
    /// </summary>
    public class StorebaeltRepository : IStorebaeltRepository
    {
        private readonly List<StoreBaeltTicket> _storeBaeltTickets;
        private int _ticketNumber;
        /// <summary>
        /// Detter er sådan det her repository bliver født.
        /// </summary>
        public StorebaeltRepository()
        {
            _storeBaeltTickets = new List<StoreBaeltTicket>();
            _ticketNumber = 1;
        }
        /// <summary>
        /// Denne metode tilføjer en billet til listen
        /// </summary>
        /// <param name="ticket"></param>
        /// <returns>Retunere den tilføjede billet</returns>
        public StoreBaeltTicket AddTicket(StoreBaeltTicket ticket)
        {
            ticket.TicketNumber = GenerateNextTicketNumber();
            _storeBaeltTickets.Add(ticket);
            return ticket;
        }
        /// <summary>
        /// Viser en liste med alle billeterne i listen
        /// </summary>
        /// <returns>Retunere listen med billetter</returns>
        public List<StoreBaeltTicket> AllTickets()
        {
            return _storeBaeltTickets;
        }
        /// <summary>
        /// Viser alle tickets i listen ved den enkelte nummerplade
        /// </summary>
        /// <param name="licensPlate"></param>
        /// <returns>Retunere billetlisten med nummerpladen tilknyttet</returns>
        public List<StoreBaeltTicket> AllTicketForLicensPlate(string licensPlate)
        {
            return _storeBaeltTickets.FindAll(x => x.Vehicle.LicensPlate == licensPlate);
        }
        private int GenerateNextTicketNumber()
        {
            return _ticketNumber++;
        }
        /// <summary>
        /// Tæller antallet af billeter i listen.
        /// </summary>
        /// <returns>Retunere antallet i heltal.</returns>
        public int TicketInList()
        {
            return _storeBaeltTickets.Count();
        }
    }
}
