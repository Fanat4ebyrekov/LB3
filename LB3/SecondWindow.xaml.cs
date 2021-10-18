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
using System.Windows.Shapes;

namespace LB3
{
    /// <summary>
    /// Логика взаимодействия для SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();
        }

        private void checkBox3_Checked(object sender, RoutedEventArgs e)
        {
            checkBox1.IsChecked = false;
            checkBox2.IsChecked = false;
        }

        private void checkBox2_Checked(object sender, RoutedEventArgs e)
        {
            checkBox3.IsChecked = false;
            checkBox1.IsChecked = false;
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {

            checkBox3.IsChecked = false;
            checkBox2.IsChecked = false;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (drawAttributes != null)
            {
                drawAttributes.Width = ((Slider)sender).Value;
                drawAttributes.Height = ((Slider)sender).Value;
            }
        }

        private void menuItemColorBlack_Click(object sender, RoutedEventArgs e)
        {
            drawAttributes.Color = Brushes.Black.Color;
        }

        private void menuItemColorGreen_Click(object sender, RoutedEventArgs e)
        {
            drawAttributes.Color = Brushes.Green.Color;
        }

        private void menuItemColorOrange_Click(object sender, RoutedEventArgs e)
        {
            drawAttributes.Color = Brushes.Orange.Color;
        }
    }
}
