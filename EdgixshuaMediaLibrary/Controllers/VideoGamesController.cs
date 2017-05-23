using EdgixshuaMediaLibrary.DataLayer;
using System.Windows;

namespace EdgixshuaMediaLibrary.Controllers
{
    class VideoGamesController
    {
        VideoGamesRespository Repository = new VideoGamesRespository();

        public void AddGameToLibrary(string gameTitle, string gameEdition, string gamePlatform, int gameYear)
        {
            if (Repository.CheckIfGameExists(gameTitle, gameEdition, gamePlatform) == true)
            {
                MessageBox.Show(gameTitle + " - " + gameEdition + " Edition " + "for " + gamePlatform + " already exists in the library");
            }
            else
            {
                Repository.AddNewGame(gameTitle, gameEdition, gamePlatform, gameYear);

                MessageBox.Show(gameTitle + " has been successfully added to the library");
            }
        }

        public int TotalGameCount()
        {
            var entireGameLibrary = Repository.GetEntireVideoGameLibrary();

            var totalGameCount = entireGameLibrary.Count;

            return totalGameCount;
        }
    }
}
