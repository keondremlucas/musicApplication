using System;

namespace ClassLib
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Sql.ShowAllAlbums();

            Console.WriteLine();
            Sql.ShowAllSongs();

            Console.WriteLine();
            Sql.ShowAllArtist();

            Console.WriteLine();
            Sql.RuntimeGreater3();

            Console.WriteLine();
            Sql.FindAlbumByArtist("kanye");

            Console.WriteLine();
            Sql.FindSongByArtist("kanye");

            Console.WriteLine();
            Sql.TotalSongsbyArtist("kanye");

            Console.WriteLine();
            Sql.FindByGenre("rap");

            Console.WriteLine();
            Sql.NumberOfSongsByAlbum("CLB");

        }
    }
}
