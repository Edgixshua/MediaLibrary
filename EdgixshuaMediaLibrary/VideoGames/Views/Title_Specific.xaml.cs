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
        VideoGamesService service = new VideoGamesService();

        public Title_Specific()
        {
            InitializeComponent();
        }

        private void Load_Data(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = service.SearchByTitle(titleSearchTextBox.Text).OrderBy(o => o.Title);
        }

        private void Game_Return_Button_Click(object sender, RoutedEventArgs e)
        {
            Video_Game_Window videoGameWindow = new Video_Game_Window();
            this.Hide();
            videoGameWindow.Show();
        }
    }
}
