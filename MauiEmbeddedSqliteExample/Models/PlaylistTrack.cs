using SQLite;
using SQLiteNetExtensions.Attributes;

namespace MauiEmbeddedSqliteExample.Models
{
    public class PlaylistTracks
    {
        [PrimaryKey, AutoIncrement]

        [ForeignKey(typeof(Playlists))]
        public int PlaylistId { get; set; }

        [ForeignKey(typeof(Tracks))]
        public int TrackId { get; set; }
    }
}
