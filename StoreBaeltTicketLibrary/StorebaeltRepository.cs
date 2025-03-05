using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace StoreBaeltTicketLibrary
{
    public class StorebaeltRepository : IStorebaeltRepository
    {
        private readonly List<StoreBaeltTicket> _storeBaeltTickets;
        private int _ticketNumber;
        public StorebaeltRepository()
        {
            _storeBaeltTickets = new List<StoreBaeltTicket>();
            _ticketNumber = 1;
        }

        public StoreBaeltTicket AddTicket(StoreBaeltTicket ticket)
        {
            ticket.TicketNumber = GenerateNextTicketNumber();
            _storeBaeltTickets.Add(ticket);
            return ticket;
        }
        public List<StoreBaeltTicket> AllTickets()
        {
            return _storeBaeltTickets;
        }
        public List<StoreBaeltTicket> AllTicketForLicensPlate(string licensPlate)
        {
            return _storeBaeltTickets.FindAll(x => x.Vehicle.LicensPlate == licensPlate);
        }
        private int GenerateNextTicketNumber()
        {
            return _ticketNumber++;
        }
        public int TicketInList()
        {
            return _storeBaeltTickets.Count();
        }
    }
}
