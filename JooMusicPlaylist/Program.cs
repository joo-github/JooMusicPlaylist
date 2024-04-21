// Program.cs (User Interface)

using System;
using MusicPlaylistBusinessLogic;
using MusicPlaylistDataLayer;
using MusicPlaylistModel;

namespace MusicPlaylistUserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var playlistDataService = new PlaylistDataService();

            var playlistService = new PlaylistService(playlistDataService);

            Console.WriteLine(" ❚█══Welcome To My Music Playlist══█❚");

           
            Console.WriteLine("1. The Night We Met - Lord Huron");
            Console.WriteLine("2. What Would I Do? - Strawberry Guy");
            Console.WriteLine("3. Same Ground - Kitchie Nadal");
            Console.WriteLine("4. Say Yes To Heaven - Lana Del Ray");
            Console.WriteLine("5. End Of Beginning - Djo");
            Console.WriteLine("6. Lips Of An Angel - Hinder");
            Console.WriteLine("7. Dark Red - Steve Lacy");
            Console.WriteLine("8. Ikaw At Ako - Moira Dela Torre");
            Console.WriteLine("9. A Piece Of You - Nathaniel Constantin");
            Console.WriteLine("10. Sweet - Cigarette After Sex");

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Enter the title of the song (or type 'exit' to quit):");
                string title = Console.ReadLine();

                if (title.ToLower() == "exit")
                {
                    exit = true;
                    continue;
                }

                Song song = playlistService.GetSong(title);
                if (song != null)
                {
                    playlistService.DisplaySongDetails(song);
                }
                else
                {
                    Console.WriteLine("Song not found!");
                }
            }
        }
    }
}