namespace FlightTickets.ConsumerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumerController : ControllerBase
    {
        private readonly ILogger<ConsumerCOntroller> _logger;
        private readonly IConsumerService _consumerService;

        pblic COnsumerCOntroller(Ilogger<ConsumerCOntroller> loger, IconsumerService consumerService)
        {
            _logger = loger;
            _consumerService = consumerService;
        }
        [HttpPost]
        public async Task<IActionResult> TicketSaveDataBase()
        {
            try
            {
                _logger.LogInformation("Reading tichets from queues...");
                await _consumerService.GetTicketsFromQueues();
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError("Shit happens..." + ex.Message);
            }
        }

    }
}
