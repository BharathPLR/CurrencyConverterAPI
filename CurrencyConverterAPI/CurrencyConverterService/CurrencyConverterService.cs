using CurrencyConverterAPI.ICurrencyService;
using CurrencyConverterAPI.Models;
using Microsoft.Extensions.Options;

namespace CurrencyConverterAPI.CurrencyService
{

    public class CurrencyConverterService : ICurrencyConverterService
    {
        private readonly List<CurrencyConversionRate> _conversionRates;

        public CurrencyConverterService(IOptions<List<CurrencyConversionRate>> conversionRates)
        {
            _conversionRates = conversionRates.Value;
        }

        public decimal Convert(string fromCurrency, string toCurrency, decimal amount)
        {
            var conversionRate = _conversionRates.FirstOrDefault(rate =>
                rate.FromCurrency.Equals(fromCurrency, StringComparison.OrdinalIgnoreCase) &&
                rate.ToCurrency.Equals(toCurrency, StringComparison.OrdinalIgnoreCase));

            if (conversionRate == null)
            {
                throw new InvalidOperationException($"Conversion rate not found for {fromCurrency} to {toCurrency}");
            }

            return amount * conversionRate.Rate;
        }
    }
}
