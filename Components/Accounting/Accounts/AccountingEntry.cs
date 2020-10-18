using System;

namespace FenixAlliance.Models.Mappers.Accounting
{
    public class AccountingEntry
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public double Debit { get; set; }
        public double Credit { get; set; }
        public string CurrencyID { get; set; }
        public string DebitedAccountID { get; set; }
        public string CreditedAccountID { get; set; }
        public string Description { get; set; }
        public string ForexRates { get; set; }
        public DateTime Timestamp { get; set; }
        public string ParentAccountID { get; set; }
    }
}
