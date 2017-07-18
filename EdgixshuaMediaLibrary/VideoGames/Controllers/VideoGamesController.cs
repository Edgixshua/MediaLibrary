using EdgixshuaMediaLibrary.DataLayer;
using System.Windows;

namespace EdgixshuaMediaLibrary.Controllers
{
    class VideoGamesController
    {
        VideoGamesService service = new VideoGamesService();

        public void AddGameToLibrary(string gameTitle, string gameEdition, string gamePlatform, int gameYear)
        {
            if (service.CheckIfGameExists(gameTitle, gameEdition, gamePlatform) == true)
            {
                MessageBox.Show(gameTitle + " - " + gameEdition + " Edition " + "for " + gamePlatform + " already exists in the library");
            }
            else
            {
                service.AddNewGame(gameTitle, gameEdition, gamePlatform, gameYear);

                MessageBox.Show(gameTitle + " has been successfully added to the library");
            }
        }

        public int TotalGameCount()
        {
            return service.GetEntireVideoGameLibrary().Count;
        }
    }
}
