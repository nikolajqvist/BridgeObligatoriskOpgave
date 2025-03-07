
namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Interfacet for ticket systemet
    /// </summary>
    public interface IStorebaeltRepository
    {
        /// <summary>
        /// Metode for at tilføje en ticket til listen.
        /// </summary>
        /// <param name="ticket"></param>
        /// <returns>retunere biletten</returns>
        StoreBaeltTicket AddTicket(StoreBaeltTicket ticket);
        /// <summary>
        /// Viser alle tickets i listen ved den enkelte nummerplade
        /// </summary>
        /// <param name="licensPlate"></param>
        /// <returns>Retunere billetlisten med nummerpladen tilknyttet</returns>
        List<StoreBaeltTicket> AllTicketForLicensPlate(string licensPlate);
        /// <summary>
        /// Listen over alle billetter i listen.
        /// </summary>
        /// <returns>Retunere listen</returns>
        List<StoreBaeltTicket> AllTickets();
    }
}