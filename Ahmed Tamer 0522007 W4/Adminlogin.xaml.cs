using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace Assessment_Ahmed_tamer
{
    /// <summary>
    /// Interaction logic for Adminlogin.xaml
    /// </summary>
    public partial class Adminlogin : Page
    {
        instaEntities db = new instaEntities();
        public Adminlogin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            admin_ admin = new admin_();
            if (name.Text != null && password.Text != null)
            {
                admin =db.admin_.First(x => x.admin_name== name.Text && x.admin_pass == password.Text);
                Adminpage page = new Adminpage();
                this.NavigationService.Navigate(page);
            }
            else
            {
                MessageBox.Show("wrong insertion");
            }
                
        }
    }
}
