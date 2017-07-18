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
using System.Configuration;
using EdgixshuaMediaLibrary.Video_Games;
using EdgixshuaMediaLibrary.VideoGames;
using System.Data.SqlClient;
using System.Data;

namespace EdgixshuaMediaLibrary
{
    /// <summary>
    /// Interaction logic for Video_Game_Window.xaml
    /// </summary>
    public partial class Video_Game_Window : Window
    {
        public Video_Game_Window()
        {
            InitializeComponent();
        }

        private void Entire_Library_Button_Click(object sender, RoutedEventArgs e)
        {
            Entire_Library entireLibrary = new Entire_Library();
            entireLibrary.Owner = this;
            this.Hide();
            entireLibrary.Show();
        }

        private void SearchBy_Platform_Button_Click(object sender, RoutedEventArgs e)
        {
            Platform_Specific platformSpecificSearch = new Platform_Specific();
            platformSpecificSearch.Owner = this;
            this.Hide();
            platformSpecificSearch.Show();
        }

        private void Add_New_Game_Button_Click(object sender, RoutedEventArgs e)
        {
            Add_New_Game addNewGame = new Add_New_Game();
            addNewGame.Owner = this;
            addNewGame.Show();
        }

        private void SearchBy_Title_Button_Click(object sender, RoutedEventArgs e)
        {
            Title_Specific titleSpecificSearch = new Title_Specific();
            titleSpecificSearch.Owner = this;
            this.Hide();
            titleSpecificSearch.Show();
        }
    }
}