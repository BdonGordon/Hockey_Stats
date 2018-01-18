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
using System.Collections;

namespace Hockey_Stats {
    /// <summary>
    /// Interaction logic for StarterControl.xaml
    /// </summary>
    public partial class StarterControl : UserControl {
        public List<string> starters_List = new List<string>();
        private int player_Position = 1; //starts off at 1. 1 = LW, 2= LD, 3= C, 4= RD, 5=RW, 6=G; starters_List[0] = LW, [1] = LD ... etc
        public Hashtable player_Table = new Hashtable();

        public StarterControl() { 
            InitializeComponent();
        }

        private void player_1_Click(object sender, RoutedEventArgs e) {
            if(player_1.Background == Brushes.LightGray) {
                player_1.Background = Brushes.Blue;
                starters_List.Add(player_1.Content.ToString());
                updatePositionNo(1);
            }
            else {
                player_1.Background = Brushes.LightGray;
                starters_List.Remove(player_1.Content.ToString());
                updatePositionNo(0);
            }
        }

        private void player_2_Click(object sender, RoutedEventArgs e) {
            if (player_2.Background == Brushes.LightGray) {
                player_2.Background = Brushes.Blue;
                starters_List.Add(player_2.Content.ToString());
                updatePositionNo(1);
            }
            else {
                player_2.Background = Brushes.LightGray;
                starters_List.Remove(player_2.Content.ToString());
                updatePositionNo(0);
            }
        }

        private void player_3_Click(object sender, RoutedEventArgs e) {
            if (player_3.Background == Brushes.LightGray) {
                player_3.Background = Brushes.Blue;
                starters_List.Add(player_3.Content.ToString());
                updatePositionNo(1);
            }
            else {
                player_3.Background = Brushes.LightGray;
                starters_List.Remove(player_3.Content.ToString());
                updatePositionNo(0);
            }
        }

        private void player_4_Click(object sender, RoutedEventArgs e) {
            if (player_4.Background == Brushes.LightGray) {
                player_4.Background = Brushes.Blue;
                starters_List.Add(player_4.Content.ToString());
                updatePositionNo(1);
            }
            else {
                player_4.Background = Brushes.LightGray;
                starters_List.Remove(player_4.Content.ToString());
                updatePositionNo(0);
            }
        }

        private void player_5_Click(object sender, RoutedEventArgs e) {
            if (player_5.Background == Brushes.LightGray) {
                player_5.Background = Brushes.Blue;
                starters_List.Add(player_5.Content.ToString());
                updatePositionNo(1);
            }
            else {
                player_5.Background = Brushes.LightGray;
                starters_List.Remove(player_5.Content.ToString());
                updatePositionNo(0);
            }
        }

        private void start_Button_Click(object sender, RoutedEventArgs e) {
            for (int i =0; i < starters_List.Count; i++) {
                Console.WriteLine(starters_List[i]);
            }
        }

        /**
         * if option = 1, then we're adding 1 to the position which will change the position Label.
         * otherwise, it will remove 1 and change the position label to the previous position
         * */
        private void updatePositionNo(int option) {
            if(option == 1) { 
                player_Position = player_Position + 1;
                updatePositionLabel(player_Position);
            }
            else {
                player_Position = player_Position - 1;
                updatePositionLabel(player_Position);
            }
        }

        private void updatePositionLabel(int position) {
            if (position == 1) {
                position_Notifier.Content = "Please select starting LW:";
            }
            else if (position == 2) {
                position_Notifier.Content = "Please select starting LD:";
            }
            else if (position == 3) {
                position_Notifier.Content = "Please select starting C:";
            }
            else if (position == 4) {
                position_Notifier.Content = "Please select starting RD:";
            }
            else if (position == 5) {
                position_Notifier.Content = "Please select starting RW:";
            }
            else if (position == 6) {
                position_Notifier.Content = "Please select starting Goalie:";
            }
        }
    }
}
