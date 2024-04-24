using SQLite;
using SQLiteNetExtensions.Attributes;

namespace MauiEmbeddedSqliteExample.Models
{
    public class InvoiceLines
    {
        [PrimaryKey, AutoIncrement]
        public int InvoiceLineId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }

        [ForeignKey(typeof(Invoices))]
        public int InvoiceId { get; set; }

        [ForeignKey(typeof(Tracks))]
        public int TrackId { get; set; }
    }
}
