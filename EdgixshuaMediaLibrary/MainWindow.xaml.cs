using EdgixshuaMediaLibrary.DataLayer;
using System.Windows;

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
    }
}
