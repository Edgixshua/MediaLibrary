using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using EdgixshuaMediaLibrary.DataLayer;
using EdgixshuaMediaLibrary.Controllers;

namespace EdgixshuaMediaLibrary.VideoGames
{
    /// <summary>
    /// Interaction logic for Platform_Specific.xaml
    /// </summary>
    public partial class Platform_Specific : Window
    {
        List<GamePlatforms> gamePlaformList = new List<GamePlatforms>();

        VideoGamesController Controller = new VideoGamesController();

        VideoGamesRespository Repository = new VideoGamesRespository();

        public Platform_Specific()
        {
            InitializeComponent();
            gamePlaformList.Add(new GamePlatforms { Icon = Properties.Resources.sony_ps4_logo, Name = "Playstation 4" });
            gamePlaformList.Add(new GamePlatforms { Icon = Properties.Resources.xbox_360_icon, Name = "Xbox 360" });
            gamePlaformList.Add(new GamePlatforms { Icon = Properties.Resources.asus_icon, Name = "PC" });
            gamePlaformList.Add(new GamePlatforms { Icon = Properties.Resources.wii_icon, Name = "Wii" });
            gamePlaformList.Add(new GamePlatforms { Icon = Properties.Resources.xbox_icon, Name = "Xbox" });
            gamePlaformList.Add(new GamePlatforms { Icon = Properties.Resources.playstation2_icon, Name = "Playstation 2" });
            gamePlaformList.Add(new GamePlatforms { Icon = Properties.Resources.gamecube_icon, Name = "Gamecube" });
            gamePlaformList.Add(new GamePlatforms { Icon = Properties.Resources.playstation_icon, Name = "Playstation" });
            gamePlaformList.Add(new GamePlatforms { Icon = Properties.Resources.ds_icon, Name = "DS" });
            gamePlaformList.Add(new GamePlatforms { Icon = Properties.Resources._3ds_icon, Name = "3DS" });
            gamePlaformList.Add(new GamePlatforms { Icon = Properties.Resources.psp_icon, Name = "PSP" });
            gamePlaformList.Add(new GamePlatforms { Icon = Properties.Resources.gameboyadvance_icon, Name = "Gameboy Advance" });
            gamePlaformList.Add(new GamePlatforms { Icon = Properties.Resources.virtualconsole_icon, Name = "Virtual Console" });
            platformComboBox.ItemsSource = gamePlaformList;
            platformComboBox.SelectedIndex = 0;
        }

        private void Load_Data(object sender, RoutedEventArgs e)
        {
            GamePlatforms platformToSearch = platformComboBox.SelectedItem as GamePlatforms;

            var videoGameList = Repository.SearchByPlatform(platformToSearch.Name);

            dataGrid.ItemsSource = videoGameList.OrderBy(o => o.Title);

            totalGameCountLabel.Content = videoGameList.Count();
        }

        private void Game_Return_Button_Click(object sender, RoutedEventArgs e)
        {
            Video_Game_Window videoGameWindow = new Video_Game_Window();
            this.Hide();
            videoGameWindow.Show();
        }
    }
}
