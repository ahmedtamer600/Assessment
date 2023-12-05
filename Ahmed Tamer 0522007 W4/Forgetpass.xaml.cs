using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for Forgetpass.xaml
    /// </summary>
    public partial class Forgetpass : Page
    {
        instaEntities db = new instaEntities();
        public Forgetpass()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                User_ user = new User_();
                user = db.User_.First(x => x.Phone == phone.Text);
                user.Password_ = password.Text;
                db.User_.AddOrUpdate(user);
                db.SaveChanges();
                MessageBox.Show("password has changed");
                Login login = new Login();
                this.NavigationService.Navigate(login);



            }
            catch { MessageBox.Show("something went wrong"); }
        }
    }
}
