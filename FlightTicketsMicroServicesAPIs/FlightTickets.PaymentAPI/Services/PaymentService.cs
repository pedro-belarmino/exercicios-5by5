using FlightTickets.Models.Models;
using FlightTickets.PaymentAPI.Services.Interfaces;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FlightTickets.PaymentAPI.Services
{
    public class PaymentService : IPaymentService
    {
        public async Task GetTicketFromQueueAsync()
        {
            try
            {
                var factory = new ConnectionFactory { HostName = "localhost" };

                using var connection = await factory.CreateConnectionAsync();

                using var channel = await connection.CreateChannelAsync();

                await channel.QueueDeclareAsync(queue: "ticketOrder",
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

                await channel.BasicConsumeAsync(queue: "ticketOrder",
                                                autoAck: true,
                                                consumer: consumer);
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while processing the ticket payment.", e);
            }
        }

        private async Task ValidatePaymentTicket(Ticket ticket)
        {
            var factory = new ConnectionFactory { HostName = "localhost" };

            using var connection = await factory.CreateConnectionAsync();

            using var channel = await connection.CreateChannelAsync();

            if (ticket.Price > 1000)
            {
                await channel.QueueDeclareAsync(queue: "ticketOrderApproved",
                                                durable: false,
                                                exclusive: false,
                                                autoDelete: false,
                                                arguments: null);

                var ticketString = JsonSerializer.Serialize(ticket);
                
                var body = Encoding.UTF8.GetBytes(ticketString);

                await channel.BasicPublishAsync(exchange: string.Empty,
                                                routingKey: "ticketOrderApproved",
                                                body: body);
            }
            else
            {
                await channel.QueueDeclareAsync(queue: "ticketOrderDenied",
                                                durable: false,
                                                exclusive: false,
                                                autoDelete: false,
                                                arguments: null);

                var ticketString = JsonSerializer.Serialize(ticket);

                var body = Encoding.UTF8.GetBytes(ticketString);

                await channel.BasicPublishAsync(exchange: string.Empty,
                                                routingKey: "ticketOrderDenied",
                                                body: body);
            }
        }
    }
}
