using CurrencyConverterAPI.Models;
using CurrencyConverterAPI.CurrencyService;
using Microsoft.Extensions.Options;

namespace CurrencyConverterAPITest
{
    public class CurrencyConverterTests
    {
        [Fact]
        public void Convert_USD_To_INR()
        {
            // Arrange
            var rates = new List<CurrencyConversionRate>
        {
            new CurrencyConversionRate { FromCurrency = "USD", ToCurrency = "INR", Rate = 76.22m }
        };
            var converter = new CurrencyConverterService(Options.Create(rates));

            // Act
            var result = converter.Convert("USD", "INR", 100);

            // Assert
            Assert.Equal(7622, result);
        }

        [Fact]
        public void Convert_INR_To_USD()
        {
            // Arrange
            var rates = new List<CurrencyConversionRate>
        {
            new CurrencyConversionRate { FromCurrency = "INR", ToCurrency = "USD", Rate = 76.22m }
        };
            var converter = new CurrencyConverterService(Options.Create(rates));

            // Act
            var result = converter.Convert("INR", "USD", 100);

            // Assert
            Assert.Equal(7622m, result);
        }

        [Fact]
        public void Convert_EUR_To_USD()
        {
            // Arrange
            var rates = new List<CurrencyConversionRate>
        {
            new CurrencyConversionRate { FromCurrency = "EUR", ToCurrency = "USD", Rate = 88.11m }
        };
            var converter = new CurrencyConverterService(Options.Create(rates));

            // Act
            var result = converter.Convert("EUR", "USD", 100);

            // Assert
            Assert.Equal(8811, result);
        }

        [Fact]
        public void Convert_USD_To_EUR()
        {
            // Arrange
            var rates = new List<CurrencyConversionRate>
        {
            new CurrencyConversionRate { FromCurrency = "USD", ToCurrency = "EUR", Rate = 88.11m }
        };
            var converter = new CurrencyConverterService(Options.Create(rates));

            // Act
            var result = converter.Convert("USD", "EUR", 100);

            // Assert
            Assert.Equal(8811m, result);
        }
        public void Convert_EUR_To_INR()
        {
            // Arrange
            var rates = new List<CurrencyConversionRate>
        {
            new CurrencyConversionRate { FromCurrency = "EUR", ToCurrency = "INR", Rate = 76.22m }
        };
            var converter = new CurrencyConverterService(Options.Create(rates));

            // Act
            var result = converter.Convert("EUR", "INR", 100);

            // Assert
            Assert.Equal(7622, result);
        }

        [Fact]
        public void Convert_INR_To_EUR()
        {
            // Arrange
            var rates = new List<CurrencyConversionRate>
        {
            new CurrencyConversionRate { FromCurrency = "INR", ToCurrency = "EUR", Rate = 76.22m }
        };
            var converter = new CurrencyConverterService(Options.Create(rates));

            // Act
            var result = converter.Convert("INR", "EUR", 100);

            // Assert
            Assert.Equal(7622, result);
        }
    }

}