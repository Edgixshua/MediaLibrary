using EdgixshuaMediaLibrary.DataLayer;
using System.Windows;

namespace EdgixshuaMediaLibrary.Controllers
{
    class VideoGamesController
    {
        public void AddGameToLibrary(string gameTitle, string gameEdition, string gamePlatform, int gameYear)
        {
            if (VideoGamesRespository.CheckGameDoesNotExist(gameTitle, gameEdition, gamePlatform) == true)
            {
                MessageBox.Show(gameTitle + " - " + gameEdition + " Edition " + "for " + gamePlatform + " already exists in the library");
            }
            else
            {
                bool gameAddSuccessful = VideoGamesRespository.AddNewGame(gameTitle, gameEdition, gamePlatform, gameYear);

                if (gameAddSuccessful == true)
                {
                    MessageBox.Show(gameTitle + " has been successfully added to the library");
                }
                else
                {
                    MessageBox.Show(gameTitle + " was not added to the library");
                }
            }
        }

        public int TotalGameCount()
        {
            var entireGameLibrary = VideoGamesRespository.GetEntireVideoGameLibrary();

            var totalGameCount = entireGameLibrary.Count;

            return totalGameCount;
        }
    }
}
