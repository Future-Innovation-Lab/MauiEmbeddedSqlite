using SQLite;

namespace MauiEmbeddedSqliteExample.Models
{
    public class Artists
    {
        [PrimaryKey, AutoIncrement]
        public int ArtistId { get; set; }
        public string Name { get; set; }
    }
}
