using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using EdgixshuaMediaLibrary.DataLayer;

namespace EdgixshuaMediaLibrary.VideoGames
{
    /// <summary>
    /// Interaction logic for Platform_Specific.xaml
    /// </summary>
    public partial class Platform_Specific : Window
    {
        List<GamePlatforms> gamePlaformList = new List<GamePlatforms>();

        VideoGamesRespository Repository = new VideoGamesRespository();

        public Platform_Specific()
        {
            InitializeComponent();
            gamePlaformList.Add(new GamePlatforms { Icon = @"C:\Projects\MediaLibrary\EdgixshuaMediaLibrary\VideoGames\VideoGameAssets\ps4_icon.jpg", Name = "Playstation 4" });
            gamePlaformList.Add(new GamePlatforms { Icon = @"C:\Projects\MediaLibrary\EdgixshuaMediaLibrary\VideoGames\VideoGameAssets\xbox_360_icon.png", Name = "Xbox 360" });
            gamePlaformList.Add(new GamePlatforms { Icon = @"C:\Projects\MediaLibrary\EdgixshuaMediaLibrary\VideoGames\VideoGameAssets\asus_icon.png", Name = "PC" });
            gamePlaformList.Add(new GamePlatforms { Icon = @"C:\Projects\MediaLibrary\EdgixshuaMediaLibrary\VideoGames\VideoGameAssets\wii_icon.jpg", Name = "Wii" });
            gamePlaformList.Add(new GamePlatforms { Icon = @"C:\Projects\MediaLibrary\EdgixshuaMediaLibrary\VideoGames\VideoGameAssets\xbox_icon.png", Name = "Xbox" });
            gamePlaformList.Add(new GamePlatforms { Icon = @"C:\Projects\MediaLibrary\EdgixshuaMediaLibrary\VideoGames\VideoGameAssets\playstation2_icon.gif", Name = "Playstation 2" });
            gamePlaformList.Add(new GamePlatforms { Icon = @"C:\Projects\MediaLibrary\EdgixshuaMediaLibrary\VideoGames\VideoGameAssets\gamecube_icon.png", Name = "Gamecube" });
            gamePlaformList.Add(new GamePlatforms { Icon = @"C:\Projects\MediaLibrary\EdgixshuaMediaLibrary\VideoGames\VideoGameAssets\playstation_icon.png", Name = "Playstation" });
            gamePlaformList.Add(new GamePlatforms { Icon = @"C:\Projects\MediaLibrary\EdgixshuaMediaLibrary\VideoGames\VideoGameAssets\ds_icon.png", Name = "DS" });
            gamePlaformList.Add(new GamePlatforms { Icon = @"C:\Projects\MediaLibrary\EdgixshuaMediaLibrary\VideoGames\VideoGameAssets\3ds_icon.png", Name = "3DS" });
            gamePlaformList.Add(new GamePlatforms { Icon = @"C:\Projects\MediaLibrary\EdgixshuaMediaLibrary\VideoGames\VideoGameAssets\psp_icon.png", Name = "PSP" });
            gamePlaformList.Add(new GamePlatforms { Icon = @"C:\Projects\MediaLibrary\EdgixshuaMediaLibrary\VideoGames\VideoGameAssets\gameboyadvance_icon.jpg", Name = "Gameboy Advance" });
            gamePlaformList.Add(new GamePlatforms { Icon = @"C:\Projects\MediaLibrary\EdgixshuaMediaLibrary\VideoGames\VideoGameAssets\virtualconsole_icon.jpg", Name = "Virtual Console" });
            platformComboBox.ItemsSource = gamePlaformList;
            platformComboBox.SelectedIndex = 0;
        }

        private void Load_Data(object sender, RoutedEventArgs e)
        {
            GamePlatforms platformToSearch = platformComboBox.SelectedItem as GamePlatforms;

            string platformName = platformToSearch.Name;

            var gameList = Repository.SearchByPlatform(platformName);

            var orderedGameList = gameList.Select(s => new { s.Title, s.Edition, s.Platform, s.Year }).ToList()
                .OrderBy(o => o.Title);

            dataGrid.ItemsSource = orderedGameList;

            int gameCount = orderedGameList.Count();

            totalGameCountLabel.Content = gameCount;
        }

        private void Game_Return_Button_Click(object sender, RoutedEventArgs e)
        {
            Video_Game_Window videoGameWindow = new Video_Game_Window();
            this.Hide();
            videoGameWindow.Show();
        }
    }
}
