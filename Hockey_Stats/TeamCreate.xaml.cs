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
    /// Interaction logic for TeamCreate.xaml
    /// </summary>
    public partial class TeamCreate : UserControl {
        public TeamCreate() {
            InitializeComponent();
        }
        //Not sure what this does yet lol
        //public static readonly DependencyProperty BadgeVisibilityProperty = DependencyProperty.Register("BadgeVisible", typeof(Visibility), typeof(TeamCreate), new PropertyMetadata(Visibility.Visible));
        /*
        public Visibility BadgeVisible {
            get { return (Visibility)GetValue(BadgeVisibilityProperty); }
            set { SetValue(BadgeVisibilityProperty, value); }
        }*/

    }
}
