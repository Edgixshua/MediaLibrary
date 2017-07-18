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
