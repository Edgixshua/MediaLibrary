using EdgixshuaMediaLibrary.VideoGames;
using System.Collections.Generic;
using EdgixshuaMediaLibrary.VideoGames.DataLayer;

namespace EdgixshuaMediaLibrary.DataLayer
{
    public class VideoGamesService
    {
        IVideoGamesRepository repo;

        public List<VideoGame> GetEntireVideoGameLibrary()
            => repo.ReturnAll();

        public List<VideoGame> SearchByPlatform(string platformName)
            => repo.PlatformSearch(platformName);

        public List<VideoGame> SearchByTitle(string title)
            => repo.TitleSearch(title);

        public bool CheckIfGameExists(string gameTitle, string gameEdition, string gamePlatform)
            => repo.IfExists(gameTitle, gameEdition, gamePlatform);

        public void AddNewGame(string gameTitle, string gameEdition, string gamePlatform, int gameYear)
            => repo.Add(gameTitle, gameEdition, gamePlatform, gameYear);
    }
}

