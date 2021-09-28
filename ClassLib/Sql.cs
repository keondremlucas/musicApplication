using System;
using Microsoft.Data.Sqlite;

namespace ClassLib
{
    public static class Sql
    {
        public static void ShowAllArtist()
        {
            using var connection = new SqliteConnection("Data Source=./musicdb.db");
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = @"
            SELECT name
            FROM artists";

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var name = reader.GetString(0);
            
                Console.WriteLine($"Artist: {name}");
            }
        }

          public static void ShowAllSongs()
        {
            using var connection = new SqliteConnection("Data Source=./musicdb.db");
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = @"
            SELECT name
            FROM songs";

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var name = reader.GetString(0);
            
                Console.WriteLine($"Song: {name}");
            }
        }

          public static void ShowAllAlbums()
        {
            using var connection = new SqliteConnection("Data Source=./musicdb.db");
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = @"
            SELECT name
            FROM albums";

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var name = reader.GetString(0);
                
                Console.WriteLine($"Album: {name}");
            }
        }

            public static void RuntimeGreater3()
        {
            using var connection = new SqliteConnection("Data Source=./musicdb.db");
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = @"
            SELECT *  
            FROM songs WHERE runtime > 3 ";

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var name = reader.GetString(1);
                var runtime = reader.GetString(4);

                Console.WriteLine($"Song: {name}, {runtime}");
            }
        }

            public static void FindAlbumByArtist(string artistname)
        {
            using var connection = new SqliteConnection("Data Source=./musicdb.db");
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = @"
            SELECT art.*, alb.*
            FROM artists art
            JOIN albums alb on alb.artist_id = art.id
            WHERE art.name LIKE $artistname";
             command.Parameters.AddWithValue("$artistname", artistname);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var name = reader.GetString(1);
                var albumname = reader.GetString(3);
               
               
                    Console.WriteLine($"Artist: {name} - Album: {albumname}");
                
            }
        }

             public static void FindSongByArtist(string artistname)
        {
            using var connection = new SqliteConnection("Data Source=./musicdb.db");
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = @"
            SELECT trk.*, art.*
            FROM artists art
            JOIN tracklist trk ON trk.artist_id = art.id
    
            ";
            //  command.Parameters.AddWithValue("$artistname", artistname);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var name = reader.GetString(1);
                var val2 = reader.GetString(2);
                var val3 = reader.GetString(3);
                
               
               
                    Console.WriteLine($"Artist: {name} - {val2} - {val3}");
                
            }
        }
    }
}