using SQLite;

namespace MauiEmbeddedSqliteExample.Models
{
    public class MediaTypes
    {
        [PrimaryKey, AutoIncrement]
        public int MediaTypeId { get; set; }
        public string Name { get; set; }
    }
}
