using CurrencyConverterAPI.Models;
using Microsoft.Extensions.Options;

namespace CurrencyConverterAPI.ICurrencyService
{
    public interface ICurrencyConverterService
    {
        decimal Convert(string fromCurrency, string toCurrency, decimal amount);
    }
}