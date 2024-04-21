// PlaylistService.cs (Business Logic Layer)

using System;
using MusicPlaylistModel;
using MusicPlaylistDataLayer;

namespace MusicPlaylistBusinessLogic
{
    public class PlaylistService
    {
        private readonly PlaylistDataService _playlistDataService;

        public PlaylistService(PlaylistDataService playlistDataService)
        {
            _playlistDataService = playlistDataService;
        }

        public Song GetSong(string title)
        {
            return _playlistDataService.GetSong(title);
        }

        public void DisplaySongDetails(Song song)
        {
            Console.WriteLine($"Title: {song.Title}");
            Console.WriteLine($"Artist: {song.Artist}");
            Console.WriteLine($"Lyrics: {song.Lyrics}");
            Console.WriteLine();
        }
    }
}