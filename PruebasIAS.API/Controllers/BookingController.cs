using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaIAS.Core.Ports;
using PruebasIAS.API.Model;
using System.Linq;

namespace PruebasIAS.API.Controllers
{
    [Route("airline/[controller]/[action]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        ILogger<BookingController> _logger;
        public BookingController(IBookingService bookingService, ILogger<BookingController> logger)
        {
            _bookingService = bookingService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetFlights()
        {
            try
            {
                var flights = await _bookingService.GetFlightsAsync();
                ResponseModel responseModel = new();
                if (!flights.Any())
                {
                    responseModel.Status = 401;
                    responseModel.Message = "Not Found";
                    responseModel.Data = null;
                    return NotFound(responseModel);
                }
                else
                {
                    responseModel.Status = 200;
                    responseModel.Message = "Current avaliable flights";
                    responseModel.Data = flights;
                    return Ok(responseModel);
                }
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "BookingController - method GetFlights");
                return StatusCode(500);
            }
        }

    }
}
