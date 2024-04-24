using SQLite;

namespace MauiEmbeddedSqliteExample.Models
{
    public class Playlists
    {
        [PrimaryKey, AutoIncrement]
        public int PlaylistId { get; set; }
        public string Name { get; set; }
    }
}
