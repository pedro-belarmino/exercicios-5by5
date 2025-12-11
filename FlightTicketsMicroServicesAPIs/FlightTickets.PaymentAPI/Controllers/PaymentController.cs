using FlightTickets.PaymentAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FlightTickets.PaymentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly ILogger<PaymentController> _logger;
        private readonly IPaymentService _paymentService;

        public PaymentController(ILogger<PaymentController> logger, IPaymentService paymentService)
        {
            _logger = logger;
            _paymentService = paymentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            try
            {
                _logger.LogInformation("Processing ticket payment...");
                await _paymentService.GetTicketFromQueueAsync();
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while processing the ticket payment.");
                return Problem(e.Message);
            }
        }
    }
}
