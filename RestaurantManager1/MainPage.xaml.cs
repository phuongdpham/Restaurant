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

namespace RestaurantManager1
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void addOrderPage_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("AddOrder.xaml", UriKind.RelativeOrAbsolute));
        }

        private void finishOrderPage_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("FinishOrder.xaml", UriKind.RelativeOrAbsolute));
        }

        private void aboutButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("About.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
