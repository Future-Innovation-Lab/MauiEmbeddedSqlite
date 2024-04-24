using SQLite;
using SQLiteNetExtensions.Attributes;

namespace MauiEmbeddedSqliteExample.Models
{
    public class Albums
    {
        [PrimaryKey, AutoIncrement]
        public int AlbumId { get; set; }
        public string Title { get; set; }

        [ForeignKey(typeof(Artists))]
        public int ArtistId { get; set; }
    }
}
