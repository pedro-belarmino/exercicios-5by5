using FlightTickets.Models.DTOs;
using FlightTickets.OrderAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FlightTickets.OrderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ILogger<TicketController> _logger;
        private readonly ITicketService _ticketService;

        public TicketController(ILogger<TicketController> logger, ITicketService ticketService)
        {
            _logger = logger;
            _ticketService = ticketService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTicketAsync([FromBody] TicketRequestDTO ticket)
        {
            _logger.LogInformation("Creating a new Ticket.");

            var createdTicket = await _ticketService.CreateTicketAsync(ticket);

            return Ok(createdTicket);

            //return CreatedAtAction(nameof(GetTicketByIdAsync), new { id = createdTicket.Id }, createdTicket);
        }
    }
}
