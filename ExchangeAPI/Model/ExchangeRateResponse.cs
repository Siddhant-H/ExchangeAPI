namespace ExchangeAPI.Model
{
    public class ExchangeRateResponse
    {
        public bool Success { get; set; }
        public bool Timeseries { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Base { get; set; }
        public Dictionary<string, exchangerates> Rates { get; set; }
    }
}
