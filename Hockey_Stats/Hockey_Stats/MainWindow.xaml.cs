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

namespace Hockey_Stats
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        public MainWindow()
        {
            InitializeComponent();
            //still works?
            ShowsNavigationUI = false;
        }
        /**
         * When clicked, a new window will be presented for the user to create the teams
         * */
        private void createTeam_button_Click(object sender, RoutedEventArgs e) {
            MainFrame.Content = new TeamPage();
            //TeamPage teamPg = new TeamPage();
        }
        
        private void gameStart_button_Click(object sender, RoutedEventArgs e) {
            MainFrame.Content = new SettingsPage();
        }
    }
}
