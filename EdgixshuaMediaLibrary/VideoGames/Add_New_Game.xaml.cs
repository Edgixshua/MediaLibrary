using EdgixshuaMediaLibrary.Controllers;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace EdgixshuaMediaLibrary.VideoGames
{
    /// <summary>
    /// Interaction logic for Add_New_Game.xaml
    /// </summary>
    public partial class Add_New_Game : Window
    {
        List<GamePlatforms> gamePlaformList = new List<GamePlatforms>();

        VideoGamesController controller = new VideoGamesController();

        public Add_New_Game()
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

            for (int i = 1980; i <= DateTime.Today.Year; i++)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = i;
                addGameYearComboBox.Items.Add(item);
            }
        }

        private void Add_Game_On_Click(object sender, RoutedEventArgs e)
        {
            GamePlatforms gamePlatformSelected = platformComboBox.SelectedItem as GamePlatforms;

            string gameTitle = addGameTitleTextBox.Text;
            string gameEdition = addGameEditionTextBox.Text;
            string gamePlatform = gamePlatformSelected.Name;
            var item = addGameYearComboBox.SelectedItem as ComboBoxItem;
            int gameYear = int.Parse(item.Content.ToString());

            controller.AddGameToLibrary(gameTitle, gameEdition, gamePlatform, gameYear);
        }
    }
}
