using System.Collections.Generic;

namespace EdgixshuaMediaLibrary.VideoGames.DataLayer
{
    public interface IVideoGamesRepository
    {
        List<VideoGame> ReturnAll();
        List<VideoGame> PlatformSearch(string platformName);
        List<VideoGame> TitleSearch(string title);
        bool IfExists(string gameTitle, string gameEdition, string gamePlatform);
        void Add(string gameTitle, string gameEdition, string gamePlatform, int gameYear);
    }
}
