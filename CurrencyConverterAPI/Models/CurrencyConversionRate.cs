namespace CurrencyConverterAPI.Models
{
    public class CurrencyConversionRate
    {
        public string FromCurrency { get; set; }
        public string ToCurrency { get; set; }
        public decimal Rate { get; set; }
    }

}
