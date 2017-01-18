using EdgixshuaMediaLibrary.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EdgixshuaMediaLibrary.VideoGames
{
    /// <summary>
    /// Interaction logic for Title_Specific.xaml
    /// </summary>
    public partial class Title_Specific : Window
    {
        public Title_Specific()
        {
            InitializeComponent();
        }

        private void Load_Data(object sender, RoutedEventArgs e)
        {
            string titleOrKeyword = titleSearchTextBox.Text;

            var gameList = VideoGamesRespository.SearchByTitle(titleOrKeyword);

            var orderedGameList = gameList.Select(s => new { s.Title, s.Edition, s.Platform, s.Year }).ToList()
                .OrderBy(o => o.Title);

            dataGrid.ItemsSource = orderedGameList;
        }

        private void Game_Return_Button_Click(object sender, RoutedEventArgs e)
        {
            Video_Game_Window videoGameWindow = new Video_Game_Window();
            this.Hide();
            videoGameWindow.Show();
        }
    }
}
