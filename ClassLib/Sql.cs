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
              SELECT tl.*, a.*, s.*
              FROM tracklist tl
              JOIN artists a on a.id = tl.artist_id
              JOIN songs s on s.id = tl.song_id
              WHERE a.name LIKE $artistname;
    
            ";
            command.Parameters.AddWithValue("$artistname", artistname);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var name = reader.GetString(5);
                var songname = reader.GetString(7);
                
                
               
               
                    Console.WriteLine($"Artist: {name} - Song: {songname}");
                
            }

            
        }
           public static void TotalSongsbyArtist(string artistname)
        {
            using var connection = new SqliteConnection("Data Source=./musicdb.db");
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = @"
            SELECT tl.*, a.*, s.*
            FROM tracklist tl
            JOIN artists a on a.id = tl.artist_id
            JOIN songs s on s.id = tl.song_id
            WHERE a.name LIKE $artistname;
            SELECT count(*) FROM $artistname";
            command.Parameters.AddWithValue("$artistname", artistname);

            using var reader = command.ExecuteReader();
            var holder = "";
            while (reader.Read())
            {
                var count = reader.GetString(0);
                var runtime = reader.GetString(4);
                holder = count;
                
            }
            
            Console.WriteLine($"Total Songs by {artistname.ToUpper()}: {holder}");
        }

          public static void FindByGenre(string genre)
        {
            using var connection = new SqliteConnection("Data Source=./musicdb.db");
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = @"
            SELECT *  
            FROM songs WHERE genre LIKE $genre";
            command.Parameters.AddWithValue("$genre", genre);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var name = reader.GetString(1);
                var runtime = reader.GetString(4);

                Console.WriteLine($"Song: {name}, {genre}");
            }
        }

          public static void NumberOfSongsByAlbum(string albumname)
        {
            using var connection = new SqliteConnection("Data Source=./musicdb.db");
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = @"
            SELECT *  
            FROM albums WHERE name LIKE $albumname;
            SELECT count(*);";
            command.Parameters.AddWithValue("$albumname",albumname);
            using var reader = command.ExecuteReader();
            var holder = "";
            while (reader.Read())
            {
                var count = reader.GetString(0);
                holder = count;
                Console.WriteLine($"Total Songs: {holder}, {albumname}");
            }
        }
    }
}