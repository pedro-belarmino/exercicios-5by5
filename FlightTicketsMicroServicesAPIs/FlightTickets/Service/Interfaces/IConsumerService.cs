namespace FlightTickets.ConsumerAPI.Service.Interfaces
{
    public class IConsumerService
    {
        Task GetTicketsFromQueues();
        Task SaveApprovedTicketsCollection(Ticket ticket);
        Task SaveDeniedTicketsToCollection(Ticket ticket);

    }
}
