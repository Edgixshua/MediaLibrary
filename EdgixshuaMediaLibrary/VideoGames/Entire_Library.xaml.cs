using EdgixshuaMediaLibrary.Controllers;
using EdgixshuaMediaLibrary.DataLayer;
using System.Data;
using System.Linq;
using System.Windows;
namespace EdgixshuaMediaLibrary.Video_Games
{
    /// <summary>
    /// Interaction logic for Entire_Library.xaml
    /// </summary>
    public partial class Entire_Library : Window
    {
        VideoGamesController controller = new VideoGamesController();

        VideoGamesRespository Repository = new VideoGamesRespository();

        public Entire_Library()
        {
            InitializeComponent();

            totalGameCountLabel.Content = controller.TotalGameCount();
        }

        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {    
            dataGrid.ItemsSource = Repository.GetEntireVideoGameLibrary().ToList().OrderBy(o => o.Title);
        }

        private void Game_Return_Button_Click(object sender, RoutedEventArgs e)
        {
            Video_Game_Window videoGameWindow = new Video_Game_Window();
            this.Hide();
            videoGameWindow.Show();
        }

        private void Refresh_Button_Click(object sender, RoutedEventArgs e)
        {
            var gameList = Repository.GetEntireVideoGameLibrary();

            dataGrid.ItemsSource = gameList.OrderBy(o => o.Title);

            totalGameCountLabel.Content = gameList.Count;
        }
    }
}
