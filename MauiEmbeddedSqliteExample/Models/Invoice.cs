using SQLite;
using SQLiteNetExtensions.Attributes;

namespace MauiEmbeddedSqliteExample.Models
{
    public class Invoices
    {
        [PrimaryKey, AutoIncrement]
        public int InvoiceId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingCountry { get; set; }
        public string BillingPostalCode { get; set; }
        public decimal Total { get; set; }

        [ForeignKey(typeof(Customers))]
        public int CustomerId { get; set; }
    }
}
