using System;
using System.Collections.Generic;
using System.Collections;
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
    /// Interaction logic for TeamPage.xaml
    /// </summary>
    public partial class TeamPage : Page {
        private string boxText;
        private int rowCount; //basically the number of players 
        //private List<RowDefinition> playerList;
        //private HashSet<RowDefinition> playerList;
        private Hashtable playerList;
        private static int addedPlayer = 0;
        

        public TeamPage() {
            InitializeComponent();
        }

        //https://code.msdn.microsoft.com/windowsapps/How-to-add-a-hint-text-to-ad928cd2
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            //Test for non-null
            if(values[0] is bool && values[1] is bool) {
                bool hasText = !(bool)values[0];
                bool hasFocus = (bool)values[1];

                if(hasFocus || hasText) {
                    return Visibility.Collapsed;
                }
            }
            return Visibility.Visible;
        }

        /**
         * When you press submit, just print out all the information from all the rows and columns
         * */
        private void submit_button_Click(object sender, RoutedEventArgs e) {
            List < string > fieldTexts= new List<string>();
            //Unsure if this is how you would/should actually handle closing the window
            if (player_1_name.Text.Length <= 0) {
                string msg = "Empty Team Name";
                string caption = "Invalid input";
                MessageBox.Show(msg, caption);
            }
            else {
                string msg = GetFields(player_1_name);
                string msg2 = GetFields(player_1_num);
                string msg3 = player_one_pos.Text;
                string caption = "Input";
                fieldTexts.Add(msg);
                fieldTexts.Add(msg2);
                rowCount = Inner_Grid.RowDefinitions.Count;
                string players = rowCount.ToString();
                MessageBox.Show(msg + ": " + msg2 + ": " + msg3 + ": " + players, caption);
                this.Visibility = Visibility.Collapsed;
            }
        }

        private void cancel_button_Click(object sender, RoutedEventArgs e) {
            
        }

        private string GetFields(TextBox boxName) {
            if(boxName.Text.Length > 0) {
                boxText = boxName.Text;
            }
            return boxText;
        }

        /**
         * Just to populate the combobox for the positions
         * */
        private void player_one_pos_Initialized(object sender, EventArgs e) {
            string[] positions = new string[] { "C", "D", "G", "LW", "RW"};
            foreach(string pos in positions) {
                player_one_pos.Items.Add(pos);
            }
        }

        private void add_player_Button_Click(object sender, RoutedEventArgs e) {
            var newPlayer = new RowDefinition();
            //playerList = new HashSet<RowDefinition>();

            newPlayer.Height = GridLength.Auto;
            
            Inner_Grid.RowDefinitions.Add(newPlayer);
        }

        private void delete_player_Button_Click(object sender, RoutedEventArgs e) {
            
        }

        private void createPlayer(RowDefinition newPlayer) {
            playerList = new Hashtable();

            //playerList.Add(newPlayer);
        }
    }
}
