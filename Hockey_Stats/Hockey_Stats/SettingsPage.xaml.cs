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

namespace Hockey_Stats {
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page {
        private static string one, two, three;
        private static double tOne, tTwo, tThree;
        private static double totalTime;

        private string teamName;

        public void setTeamName(string teamName) {
            this.teamName = teamName;
        }
        public string getTeamName() {
            return teamName;
        }
        private void team_name_One_Click(object sender, RoutedEventArgs e) {
            //    Name = team_name_One.Content.ToString();
        }


        public SettingsPage() {
            InitializeComponent();
            UpdateGametime();
        }

        //https://code.msdn.microsoft.com/windowsapps/How-to-add-a-hint-text-to-ad928cd2
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            //Test for non-null
            if (values[0] is bool && values[1] is bool) {
                bool hasText = !(bool)values[0];
                bool hasFocus = (bool)values[1];

                if (hasFocus || hasText) {
                    return Visibility.Collapsed;
                }
            }
            return Visibility.Visible;
        }

        private void opponent_Box_GotFocus(object sender, RoutedEventArgs e) {
            if(String.Compare(opponent_Box.Text, "Team Name") == 0) {
                opponent_Box.Clear();
            }
            opponent_Box.Foreground = Brushes.Black;
        }

        private void opponent_Box_LostFocus(object sender, RoutedEventArgs e) {
            if (String.Compare(opponent_Box.Text, "Team Name", false) == 0 || String.IsNullOrEmpty(opponent_Box.Text)) {
                opponent_Box.Text = "Team Name";
                opponent_Box.Foreground = Brushes.Gray;
            }
            else {
                opponent_Box.Foreground = Brushes.Black;
            }
        }

        private void date_Box_GotFocus(object sender, RoutedEventArgs e) {
            if (String.Compare(date_Box.Text, "Month date, year") == 0) {
                date_Box.Clear();
            }
            date_Box.Foreground = Brushes.Black;
        }

        private void date_Box_LostFocus(object sender, RoutedEventArgs e) {
            if (String.Compare(date_Box.Text, "Month date, year", false) == 0 || String.IsNullOrEmpty(date_Box.Text)) {
                date_Box.Text = "Month date, year";
                date_Box.Foreground = Brushes.Gray;
            }
            else {
                date_Box.Foreground = Brushes.Black;
            }
        }

        private void location_Box_GotFocus(object sender, RoutedEventArgs e) {
            if (String.Compare(location_Box.Text, "Facility (Optional), City, Province") == 0) {
                location_Box.Clear();
            }
            location_Box.Foreground = Brushes.Black;
        }

        private void location_Box_LostFocus(object sender, RoutedEventArgs e) {
            if (String.Compare(location_Box.Text, "Facility (Optional), City, Province", false) == 0 || String.IsNullOrEmpty(location_Box.Text)) {
                location_Box.Text = "Facility (Optional), City, Province";
                location_Box.Foreground = Brushes.Gray;
            }
            else {
                location_Box.Foreground = Brushes.Black;
            }
        }

        private void start_Button_Click(object sender, RoutedEventArgs e) {
            GamePage gPage = new GamePage();
            NavigationService.Navigate(gPage);
        }

        private void cancel_Button_Click(object sender, RoutedEventArgs e) {
            SettingsPage setPage = new SettingsPage();
            MainWindow mainPage = new MainWindow();
            NavigationService.Navigate(mainPage);
            //obj.MainFrame
            //obj.MainFrame
            //obj.Show();
        }

        

        private void UpdateGametime() {
            if (BoxPeriodOne != null || BoxPeriodTwo != null || BoxPeriodThree != null) {
                one = SldPeriodOne.Value.ToString();
                two = SldPeriodTwo.Value.ToString();
                three = SldPeriodThree.Value.ToString();
                tOne = System.Convert.ToInt32(one);
                tTwo = System.Convert.ToInt32(two);
                tThree = System.Convert.ToInt32(three);

                totalTime = tOne + tTwo + tThree;

                Total_Time.Content = totalTime.ToString();
            }
        }

        private void SldPeriodOne_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            UpdateGametime();
        }
        private void SldPeriodTwo_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            UpdateGametime();
        }
        private void SldPeriodThree_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            UpdateGametime();
        }
    }
}
