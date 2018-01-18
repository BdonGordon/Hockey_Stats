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
        private List<RowDefinition> players_List = new List<RowDefinition>();
        private List<TextBox> fullName_List = new List<TextBox>();
        private List<TextBox> jerseyNum_List = new List<TextBox>();
        private static int addedPlayer;
        private TextBox global_name_Texbox;

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
         * May 1, 2017 - still has no new functionality. This won't be changed until rows and be added 
         * dynamically
         * */
        private void submit_button_Click(object sender, RoutedEventArgs e) {
            List < string > fieldTexts= new List<string>();
            int jerseyNums = jersey_Values();
            //Unsure if this is how you would/should actually handle closing the window
            if (teamName_Input.Text.Length <= 0) {
                string msg = "Empty Team Name";
                string caption = "Invalid input";
                MessageBox.Show(msg, caption);
            }
            else if(jerseyNums != 1) {
                
            }
            //Export all info into the DB
            else {
                this.Visibility = Visibility.Collapsed;
                //reset the number of players
                addedPlayer = 0;
            }
        }

        private void cancel_button_Click(object sender, RoutedEventArgs e) {
            GetFields();
        }

        private void GetFields() {
            foreach (TextBox nameInput in fullName_List) {
                //This will be added into a Database
                MessageBox.Show(nameInput.Text);
            }
            foreach(TextBox numInput in jerseyNum_List) {
                MessageBox.Show(numInput.Text);
            }
            foreach(RowDefinition row in players_List) {
                Console.WriteLine(row);
            }
        }

        /**
         * PRE: There has to be textboxes for jersey numbers present
         * POST: Returns valid_input 
         * COND: valid_input will only be 1 (therefore valid for submission) iff the J-Num is 
         *      => 1 || <= 2 characters in length; only contains DIGIT characters; no repitition 
         * */
        private int jersey_Values() {
            int valid_input = -1;
            int outParse;

            foreach (TextBox numInput in jerseyNum_List) {
                if(numInput.Text.Length > 2) {
                    MessageBox.Show("Invalid jersey number.");
                    valid_input = 0;
                }
                else if(numInput.Text.Length < 1) {
                    valid_input = 0;
                }
                //checks if the input is NOT an integer
                else if (!Int32.TryParse(numInput.Text, out outParse)) {
                    
                    valid_input = 0;
                }
                else {
                    valid_input = 1;
                }
            }

            return valid_input;
        }
        

        private void add_player_Button_Click(object sender, RoutedEventArgs e) {
            createPlayer();
        }

        private void delete_player_Button_Click(object sender, RoutedEventArgs e) {
            
        }

        private void createPlayer() {
            var newRow = new RowDefinition();
            TextBox tempName = newBox_Creation(1); //tempNameorary
            
            TextBox tempNum = newBox_Creation(2);
            ComboBox tempPos = newComboBox_Creation(); //tempNameorary
            Label tempPlus = new Label();
            Label tempMinus = new Label(); //tempNameorary
           
            tempPlus.Content = "+";
            tempMinus.Content = "-";

            newRow.Height = GridLength.Auto;
            Inner_Grid.RowDefinitions.Add(newRow);
            Inner_Grid.Children.Add(tempName);
            Inner_Grid.Children.Add(tempNum);
            Inner_Grid.Children.Add(tempPos);
            Inner_Grid.Children.Add(tempPlus);
            Inner_Grid.Children.Add(tempMinus);
            players_List.Add(newRow);

            addedPlayer = players_List.Count; //probably take out plus one.. just here now b/c row is defined there already in .xaml
            Grid.SetRow(tempName, addedPlayer);
            //Grid.SetColumn(tempName, 0);
            Grid.SetRow(tempNum, addedPlayer);
            Grid.SetColumn(tempNum, 1);

            Grid.SetRow(tempPos, addedPlayer);
            Grid.SetColumn(tempPos, 2);

            Grid.SetRow(tempPlus, addedPlayer);
            Grid.SetColumn(tempPlus, 3);

            Grid.SetRow(tempMinus, addedPlayer);
            Grid.SetColumn(tempMinus, 4);

            //MessageBox.Show(addedPlayer.ToString());
        }

        /**
         * Creates Textbox with the respective requirements needed in it (ie. Full Name, Number).
         * int field - 1 = Full Name; 2 = Number
         * */
        private TextBox newBox_Creation(int field) {
            int j = 1;
            if(field == 1) { 
                TextBox newPlayer_Name = new TextBox();
                newPlayer_Name.Margin = new Thickness(10, 10, 10, 10);
                //newPlayer_Name.Text = "Full Name";
                newPlayer_Name.Foreground = Brushes.Gray;
                newPlayer_Name.MinWidth = 85;
                //Naming the Textbox dynamically; could probably even use addedPlayer
                newPlayer_Name.Name = "fullName" + addedPlayer.ToString();
                newPlayer_Name.Text = newPlayer_Name.Name;
                fullName_List.Add(newPlayer_Name);

                global_name_Texbox = newPlayer_Name;
                global_name_Texbox.GotFocus += myBox_GotFocus;
            }

            else {
                TextBox newPlayer_Num = new TextBox();
                newPlayer_Num.Margin = new Thickness(10, 10, 10, 10);
                newPlayer_Num.Text = "Jersey #";
                newPlayer_Num.Foreground = Brushes.Gray;
                newPlayer_Num.MinWidth = 55;
                newPlayer_Num.Name = "jerseyNo" + addedPlayer.ToString();
                newPlayer_Num.Text = newPlayer_Num.Name;
                jerseyNum_List.Add(newPlayer_Num);

                global_name_Texbox = newPlayer_Num;
                global_name_Texbox.GotFocus += myBox_GotFocus;
            }

            return global_name_Texbox;
        }

        private ComboBox newComboBox_Creation() {
            ComboBox positions = new ComboBox();

            positions.Width = 50;
            positions.Margin = new Thickness(10, 10, 10, 10);
            positions.IsEditable = true;
            positions.IsReadOnly = true;
            positions.Text = "Position";

            string[] position_titles = new string[] { "C", "D", "G", "LW", "RW" };
            foreach (string pos in position_titles) {
                positions.Items.Add(pos);
            }

            return positions;
        }

        private void TextBox_MouseDown(object sender, MouseButtonEventArgs e) {
            
        }

        /**
         * When the user clicks the textbox, the current text will clear.
         * This might actually have to be TouchEnter event instead though
         * */
        private void myBox_GotFocus(object sender, RoutedEventArgs e) {
            global_name_Texbox.Clear();
            global_name_Texbox.Foreground = Brushes.Black;
        }
    }
}
