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

namespace PrototypeSimCirc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void open(object sender, RoutedEventArgs e)
        {
            if(popup.Visibility == Visibility.Visible)
            {
                popup.Visibility = Visibility.Hidden;
            } else
            {
                popup.Visibility = Visibility.Visible;
            }
        }

        private void open2(object sender, RoutedEventArgs e)
        {
            if (popup1.Visibility == Visibility.Visible)
            {
                popup1.Visibility = Visibility.Hidden;
            }
            else
            {
                popup1.Visibility = Visibility.Visible;
            }
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
