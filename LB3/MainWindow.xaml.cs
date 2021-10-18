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

namespace LB3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menuItemCloseWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void menuItemGetInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mini-Paint");
        }

        private void menuItemChangeColor_Click(object sender, RoutedEventArgs e)
        {
        }

        private void menuItemColorBlack_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Black;
        }

        private void menuItemColorGreen_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Green;
        }

        private void menuItemColorOrange_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Orange;
        }

        private void menuItemColorBlack_MouseEnter(object sender, MouseEventArgs e)
        {
            txtBlockProperty.Text = "Это кнопка изменения цвета на черный";
        }

        private void menuItemColorGreen_MouseEnter(object sender, MouseEventArgs e)
        {
            txtBlockProperty.Text = "Это кнопка изменения цвета на зеленый ";
        }

        private void menuItemColorOrange_MouseEnter(object sender, MouseEventArgs e)
        {
            txtBlockProperty.Text = "Это кнопка изменения цвета на оранжевый";
        }

        private void menuItemGetInfo_MouseEnter(object sender, MouseEventArgs e)
        {
            txtBlockProperty.Text = "Это кнопка покажет информацию о программисте";
        }

        private void menuItemCloseWindow_MouseEnter(object sender, MouseEventArgs e)
        {
            txtBlockProperty.Text = "Это кнопка закроет окно";
        }

        private void btnToNext_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow second = new SecondWindow();
            second.ShowDialog();
        }

        private void toolBarItemColorChange_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
