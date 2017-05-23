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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EdgixshuaMediaLibrary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MappingConfig config = new MappingConfig();

        public MainWindow()
        {
            InitializeComponent();

            config.SetupMappings();
        }

        private void Video_Game_Button_Click(object sender, RoutedEventArgs e)
        {
            Video_Game_Window videoGameWindow = new Video_Game_Window();
            videoGameWindow.Owner = this;
            this.Hide();
            videoGameWindow.Show();
        }

        private void Dvd_Button_Click(object sender, RoutedEventArgs e)
        {
            Dvd_Window dvdWindow = new Dvd_Window();
            dvdWindow.Owner = this;
            this.Hide();
            dvdWindow.Show();
        }
    }
}
