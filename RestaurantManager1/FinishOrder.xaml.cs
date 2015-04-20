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
    /// Interaction logic for FinishOrder.xaml
    /// </summary>
    public partial class FinishOrder : Page
    {
        public FinishOrder()
        {
            InitializeComponent();
            BindingGridResult();
            BindingComboBox();
        }

        private void BindingComboBox()
        {
            using (var res = new RestaurantContext())
            {
                var tableList = res.DiningTables.Select(x => x.TableNo).ToList();
                tbCB.ItemsSource = tableList;
                tbCB.SelectedItem = tableList.FirstOrDefault();
            }
        }

        private void BindingGridResult()
        {
            using (var res = new RestaurantContext())
            {
                var listOrders = res.Orders.Join(res.Dishs, o => o.DishId, d => d.DishId,
                                                 (o, d) => new { o.TableNo, o.DishId, d.Name, d.Price, o.Quantity }).ToList();

                gridResult.ItemsSource = listOrders;
            }
        }

        private void getReusult_Click(object sender, RoutedEventArgs e)
        {
            int tbNo = (int)tbCB.SelectedItem;
            using (var res = new RestaurantContext())
            {
                var listOrders = res.Orders.Join(res.Dishs, o => o.DishId, d => d.DishId,
                                                 (o, d) => new { o.TableNo, d.Price, o.Quantity }).
                                                 Where(od => od.TableNo == tbNo).ToList();
                int sum = 0;

                foreach (var item in listOrders)
                {
                    sum += (int)item.Quantity * item.Price;
                }

                totalTBl.Text = sum.ToString();
            }
        }

        private void clearOrders_Click(object sender, RoutedEventArgs e)
        {
            int tbNo = (int)tbCB.SelectedItem;
            using (var res = new RestaurantContext())
            {
                var orders = res.Orders.Where(o => o.TableNo == tbNo).ToList();
                foreach (var order in orders)
                {
                    res.Orders.Remove(order);
                }
                res.SaveChanges();
                BindingGridResult();
                totalTBl.Text = "0";
            }
        }
    }
}
