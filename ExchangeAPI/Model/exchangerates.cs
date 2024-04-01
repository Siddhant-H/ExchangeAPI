using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace ExchangeAPI.Model
{
    
    public class exchangerates
    {
        [Key]
        public long currency_id { get; set; }
        public string base_currency { get; set; }
        public DateTime date { get; set; }
        public decimal USD { get; set; }
        public decimal MXN { get; set; }
        public decimal EUR { get; set; }
        public decimal CHF { get; set; }

    }

}
