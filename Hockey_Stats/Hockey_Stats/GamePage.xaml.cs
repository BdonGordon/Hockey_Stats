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
using System.Windows.Threading;

namespace Hockey_Stats {
    /// <summary>
    /// Interaction logic for GamePage.xaml
    /// </summary>
    public partial class GamePage : Page {

        private int period_Times = 600; //this will be initialized via functions but for now hardcode it
        private DispatcherTimer period_Timer;

        public GamePage() {
            InitializeComponent();
            period_Timer = new DispatcherTimer();
            period_Timer.Interval = new TimeSpan(0, 0, 1); //in hour, minutes, second 
            //period_Timer.Interval = TimeSpan.FromMilliseconds(1);
            period_Timer.Tick += period_Timer_Tick;
            double start_Time = period_Times / 60;
            double start_Seconds = period_Times % 60;
            if (start_Time < 10) {
                clock_Label.Content = string.Format("0{0}:00", start_Time);
            }
            else {
                clock_Label.Content = string.Format("{0}:00", start_Time);
            }
            //period_Timer.Start();
            preGame_Starters();
        }

        private void preGame_Starters() {
            
            Window preGame = new Window {
                Title = "Starting Players",
                Content = new StarterControl(),
                ResizeMode = ResizeMode.NoResize
            };
          
            preGame.Height = 400;
            preGame.Width = 500;
            preGame.ShowDialog();
        }

        private void period_Timer_Tick(object sender, EventArgs e) {
            //clock_Label.Content = DateTime.Now.ToLongTimeString();
            //clock_Label.Content = DateTime.Now.ToString("mm:ss.fff");
            double minutes = period_Times / 60;
            double seconds = period_Times % 60;
            //Console.WriteLine("Mins: {0}  || Seconds: {1}", minutes, seconds );
            if(period_Times >= 0) {
                period_Times--;
                if(minutes<10 && seconds <10) {
                    clock_Label.Content = string.Format("0{0}:0{1}", minutes, seconds);
                }
                else if (minutes >= 10 && seconds < 10) {
                    clock_Label.Content = string.Format("{0}:0{1}", minutes, seconds);
                }
                else if( minutes < 10 && seconds >= 10) {
                    clock_Label.Content = string.Format("0{0}:{1}", minutes, seconds);
                }
                else {
                    clock_Label.Content = string.Format("{0}:{1}", minutes, seconds);
                }
                
            }
            else {
                period_Timer.Stop();
                //MessageBox.Show("Done");
            }
        }

        private void pause_play_Button_Click(object sender, RoutedEventArgs e) {
            if(String.Compare(pause_play_Button.Content.ToString(), "Play") == 0) {
                period_Timer.Start();
                pause_play_Button.Content = "Pause";
            }
            else if(String.Compare(pause_play_Button.Content.ToString(), "Pause") == 0) {
                period_Timer.Stop();
                pause_play_Button.Content = "Play";
            }
        }

        private void left_wing_Button_Click(object sender, RoutedEventArgs e) {

        }

        private void bench_position_1_Click(object sender, RoutedEventArgs e) {

        }

        private void bench_position_2_Click(object sender, RoutedEventArgs e) {

        }
        
    }
}
