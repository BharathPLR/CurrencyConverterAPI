using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CurrencyConverterAPI.ICurrencyService;

namespace CurrencyConverterAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyConverterController : ControllerBase
    {
        private readonly ICurrencyConverterService _converterService;
        private readonly ILogger<CurrencyConverterController> _logger;

        public CurrencyConverterController(ICurrencyConverterService converterService, ILogger<CurrencyConverterController> logger)
        {
            _converterService = converterService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult ConvertCurrency(string from, string to, decimal amount)
        {
            try
            {
                _logger.LogInformation("ConvertCurrency "+ from + "to" + to);
                var convertedAmount = _converterService.Convert(from, to, amount);
                return Ok(new { Amount = convertedAmount });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while converting currency.");
                return StatusCode(500, "An error occurred while converting currency.");
            }
        }
    }
}
