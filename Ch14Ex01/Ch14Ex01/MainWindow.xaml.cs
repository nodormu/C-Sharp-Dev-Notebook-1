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

namespace Ch14Ex01
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

        private void Grid_KeyDown(object sender, KeyEventArgs e) // Notice how the KeyEventArgs don't display a window with an OK to click on as with the RoutedEventArgs.
        {
            MessageBox.Show("Grid handler, bubbling up");
        }
        private void Grid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Grid handler, tunneling down");
        }
        private void RotatedButton_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("rotatedButton handler, bubbling up"); // When an event travels UP the control hierarchy, opposite to tunneling.
                    }
        private void RotatedButton_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("rotatedButton handler, tunneling down"); // When the event travels DOWN the hierarchy, opposite to bubbling.
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Window handler, bubbling up");
        }
        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Window handler, tunneling down");
        }
        private void Button_Click(object sender, RoutedEventArgs e) // Routed events are different in that they can send the event to all controls in the hierarchy in which the control participates
        {
            MessageBox.Show("Button Click, This is a routed event. When you mouse over the button, that's the key event."); // Comment out the line and examine the difference in the application with debugging.
        }
    }
}