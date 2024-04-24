using SQLite;
using SQLiteNetExtensions.Attributes;

namespace MauiEmbeddedSqliteExample.Models
{

    public class Tracks
    {
        [PrimaryKey, AutoIncrement]
        public int TrackId { get; set; }
        public string Name { get; set; }
        public string Composer { get; set; }
        public int Milliseconds { get; set; }
        public int Bytes { get; set; }
        public decimal UnitPrice { get; set; }

        [ForeignKey(typeof(Albums))]
        public int AlbumId { get; set; }

        [ForeignKey(typeof(MediaTypes))]
        public int MediaTypeId { get; set; }

        [ForeignKey(typeof(Genres))]
        public int GenreId { get; set; }
    }
}
