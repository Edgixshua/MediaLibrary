using EdgixshuaMediaLibrary.Controllers;
using EdgixshuaMediaLibrary.DataLayer;
using EdgixshuaMediaLibrary.VideoGames;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace EdgixshuaMediaLibrary.Video_Games
{
    /// <summary>
    /// Interaction logic for Entire_Library.xaml
    /// </summary>
    public partial class Entire_Library : Window
    {
        VideoGamesController controller = new VideoGamesController();

        public Entire_Library()
        {
            InitializeComponent();

            var totalGameCount = controller.TotalGameCount();
            totalGameCountLabel.Content = totalGameCount;
        }

        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            var gameList = VideoGamesRespository.GetEntireVideoGameLibrary();

            var grid = sender as DataGrid;
            var orderedGameList = gameList.Select(s => new { s.Title, s.Edition, s.Platform, s.Year }).ToList()
                .OrderBy(o => o.Title);            

            grid.ItemsSource = orderedGameList;
        }

        private void Game_Return_Button_Click(object sender, RoutedEventArgs e)
        {
            Video_Game_Window videoGameWindow = new Video_Game_Window();
            this.Hide();
            videoGameWindow.Show();
        }

        private void Refresh_Button_Click(object sender, RoutedEventArgs e)
        {
            var gameList = VideoGamesRespository.GetEntireVideoGameLibrary();

            var orderedGameList = gameList.Select(s => new { s.Title, s.Edition, s.Platform, s.Year }).ToList()
                .OrderBy(o => o.Title);

            dataGrid.ItemsSource = orderedGameList;

            var totalGameCount = controller.TotalGameCount();
            totalGameCountLabel.Content = totalGameCount;
        }
    }
}
