using System;

namespace FenixAlliance.Models.Mappers.Accounting
{
    public class Account
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public double Balance { get; set; }
        public string CurrencyID { get; set; }
        public DateTime Timestamp { get; set; }
        public string ParentAccountID { get; set; }
    }
}
