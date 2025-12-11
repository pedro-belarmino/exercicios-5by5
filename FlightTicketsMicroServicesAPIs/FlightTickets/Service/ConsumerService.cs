using FlightTickets.ConsumerAPI.Service.Interfaces;

namespace FlightTickets.ConsumerAPI.Service
{
    public class ConsumerService : IConsumerService
    {


        private readonly ILogger<ConsumerService> _logger;
        private readonly IConsumerRepository _consumerRepository;
         
        public async Task GetTicketsFromQueues()
        {
            try
            {
                var factory = new ConnectionFactory { HostName = "localhost" };

                using var connection = await factory.CreateConnectionAsync();

                using var channel = await connection.CreateChannelAsync();

                await channel.QueueDeclareAsync(queue: "TicketsApproved",
                                                durable: false,
                                                exclusive: false,
                                                autoDelete: false,
                                                arguments: null);

                var consumer = new AsyncEventingBasicConsumer(channel);

                consumer.ReceivedAsync += async (model, ea) =>
                {
                    var body = ea.Body.ToArray();

                    var message = Encoding.UTF8.GetString(body);

                    var ticket = JsonSerializer.Deserialize<Ticket>(message);

                    await ValidatePaymentTicket(ticket);
                };

                await channel.BasicConsumeAsync(queue: "TicketsApproved",
                                                autoAck: true,
                                                consumer: consumer);




                await channel.QueueDeclareAsync(queue: "TicketsDenied",
                                                durable: false,
                                                exclusive: false,
                                                autoDelete: false,
                                                arguments: null);

                var consumer = new AsyncEventingBasicConsumer(channel);

                consumer.ReceivedAsync += async (model, ea) =>
                {
                    var body = ea.Body.ToArray();

                    var message = Encoding.UTF8.GetString(body);

                    var ticket = JsonSerializer.Deserialize<Ticket>(message);

                    await ValidatePaymentTicket(ticket);
                };

                await channel.BasicConsumeAsync(queue: "TicketsDenied",
                                                autoAck: true,
                                                consumer: consumer);

            }
            catch
            {

            }
        }

        public Task SavaApprovedTicketsToColletion(Ticket ticket)
        {
            try
            {
                await _consumerRepository.SavaApprovedTicketsAsync(Ticket ticket){

                }
            }
        }
    
    public Task SabeApprovedTicketsFromCOllection(Ticket ticket)
        {
            
        }
    }
}
