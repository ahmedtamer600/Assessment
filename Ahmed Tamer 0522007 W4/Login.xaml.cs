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

namespace Assessment_Ahmed_tamer
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        instaEntities db = new instaEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {

                if (name.Text != null && pass.Password != null)
                {

                    
                    User_ user = new User_();
                    user = db.User_.First(x => x.username == name.Text && x.Password_ == pass.Password);
                    MessageBox.Show("login complete");

                    string names = name.Text;
                    newprofile newprofile = new newprofile(names);
                    this.NavigationService.Navigate(newprofile);

                }
                else
                {

                }
            }
           

            catch { MessageBox.Show("Wrong insertion"); }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Signup signup = new Signup();
            this.NavigationService.Navigate(signup);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Forgetpass forgetpass = new Forgetpass();
            this.NavigationService.Navigate(forgetpass);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
          
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Adminlogin login = new Adminlogin();
            this.NavigationService.Navigate(login);
        }
    }
}
