using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for AddOrder.xaml
    /// </summary>
    public partial class AddOrder : Page
    {
        public AddOrder()
        {
            InitializeComponent();
            BindingTableNo();
            BindingMenu();
        }

        private void BindingMenu()
        {
            using (var restaurantDB = new RestaurantContext())
            {
                var menus = restaurantDB.Dishs.Select(x => new { x.DishId, x.Name, x.Price, x.Status }).ToList();
                gridMenu.ItemsSource = menus;
                gridMenu.DataContext = menus;
            }
        }

        private void BindingTableNo()
        {
            using (var restaurantDB = new RestaurantContext())
            {
                var dintableList = restaurantDB.DiningTables.Select(x => x.TableNo).ToList();
                tableNoCB.ItemsSource = dintableList;
                tableNoCB.SelectedItem = dintableList.FirstOrDefault();
            }
        }

        private void addOrder_Cliked(object sender, RoutedEventArgs e)
        {
            string orderString = orderTB.Text.Trim();

            if (String.IsNullOrEmpty(orderString))
            {
                MessageBox.Show("Order is empty. Please fill your orders in it.");
                return;
            }

            string[] listOrder = Regex.Split(orderString, @"\W+");

            int len = listOrder.Length;
            int[] ids = new int[len / 2];
            int[] quants = new int[len / 2];

            // Chuyen cac so trong mang listOrder lan luot vao 2 mang ids va quants
            for (int i = 0; i < len; i++)
            {
                if (i % 2 == 0)
                {
                    ids[i / 2] = int.Parse(listOrder[i]);
                }
                else
                {
                    quants[i / 2] = int.Parse(listOrder[i]);
                }
            }

            if (!checkValidData(ids))
            {
                MessageBox.Show("Order list have invalid number. Please check careful in menu!");
                return;
            }

            // Add vao database
            int tableNo = (int)tableNoCB.SelectedValue;
            using (var rest = new RestaurantContext())
            {
                for (int i = 0; i < len/2; i++)
                {
                    rest.Orders.Add(new Order { TableNo = tableNo, DishId = ids[i], ReversedTime = DateTime.Now, Quantity = quants[i] });
                }

                rest.SaveChanges();
            }

            MessageBox.Show("Added orders to database!");
            orderTB.Text = null;
        }

        private bool checkValidData(int[] ids)
        {
            using (var resource = new RestaurantContext())
            {
                var IdList = resource.Dishs.Select(x => x.DishId).ToList();

                foreach (int item in ids)
                {
                    if (IdList.IndexOf(item) == -1)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        private void finish_Clicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("FinishOrder.xaml", UriKind.RelativeOrAbsolute));
        }

        private void mainPage_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
