using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
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

namespace Assessment_Ahmed_tamer
{
    /// <summary>
    /// Interaction logic for Adminpage.xaml
    /// </summary>
    public partial class Adminpage : Page
    {
        instaEntities db = new instaEntities();
        public Adminpage()
        {
            InitializeComponent();
            datagrid.ItemsSource = db.User_.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User_ user = new User_();

            datagrid.ItemsSource = db.User_.Where(x => x.city ==city.Text).ToList();
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            User_ user = new User_();

            if (phone.Text != null)
            {
                user = db.User_.Remove(db.User_.First(x => x.Phone == phone.Text));
                db.SaveChanges();
                MessageBox.Show("row deleted");
               
            }
            else
            {
                MessageBox.Show("phone does not exist");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = db.User_.ToList();
            phone.Text = " ";
            city.Text = " ";

        }
    }
}
