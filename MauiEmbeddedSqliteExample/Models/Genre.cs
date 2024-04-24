using SQLite;

namespace MauiEmbeddedSqliteExample.Models
{
    public class Genres
    {
        [PrimaryKey, AutoIncrement]
        public int GenreId { get; set; }
        public string Name { get; set; }
    }
}
