using MauiEmbeddedSqliteExample.Models;
using SQLite;
using System.Reflection;

namespace MauiEmbeddedSqliteExample.Services
{
    public class MusicDatabaseService
    {
        private SQLiteConnection _dbConnection;

        public string GetDatabasePath()
        {
            string filename = "chinook.db";
            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(pathToDb, filename);
        }

        private void ExtractDbEmbeddedResource()
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MusicDatabaseService)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("MauiEmbeddedSqliteExample.EmbeddedDb.chinook.db");

            var path = GetDatabasePath();

            if (stream != null)
            {
                using (BinaryReader br = new BinaryReader(stream))
                {
                    using (FileStream fs = new FileStream(path, FileMode.Create))
                    {
                        BinaryWriter bw = new BinaryWriter(fs);
                        byte[] bytes = new byte[stream.Length];
                        stream.Read(bytes, 0, bytes.Length);
                        bw.Write(bytes);
                    }
                }
            }
        }

        public MusicDatabaseService()
        {
            if (!File.Exists(GetDatabasePath()))
                ExtractDbEmbeddedResource();

            _dbConnection = new SQLiteConnection(GetDatabasePath());
        }

        public List<Tracks> GetTracks()
        {
            return _dbConnection.Table<Tracks>().ToList();
        }
    }
}
