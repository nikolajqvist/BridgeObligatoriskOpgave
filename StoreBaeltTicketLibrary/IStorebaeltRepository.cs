
namespace StoreBaeltTicketLibrary
{
    public interface IStorebaeltRepository
    {
        StoreBaeltTicket AddTicket(StoreBaeltTicket ticket);
        List<StoreBaeltTicket> AllTicketForLicensPlate(string licensPlate);
        List<StoreBaeltTicket> AllTickets();
        int TicketInList();
    }
}