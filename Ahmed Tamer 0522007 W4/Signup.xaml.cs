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

namespace Assessment_Ahmed_tamer
{
   
    
    /// <summary>
    /// Interaction logic for Signup.xaml
    /// </summary>
    public partial class Signup : Page
    {
        instaEntities db = new instaEntities();
        public Signup()
        {
            InitializeComponent();
            
        }
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           String d = combo.SelectedItem.ToString().Split(' ').Last();
            String f = Gcombo.SelectedItem.ToString().Split(' ').Last();

           

            User_ user = new User_();
            if(Regex.IsMatch(pass.Text ,@"^(?=.*[A-Z])(?=.*\b)(?=.*[!@#$%^&*?]).+$" ))
            {
               
                if(d =="Giza")
                {
                    user.city = "Giza";
                }
                else if(d =="Cairo")
                {
                    user.city = "Cairo";
                }
                else if(d =="mansoura")
                {
                    user.city = "mansoura";
                } else if(d =="alex")
                {
                    user.city = "alex";
                }
                else if(d =="monofia")
                {
                    user.city = "monofia";
                }
                else { MessageBox.Show("error"); }
                if (f =="Male")
                {
                    user.gender = "Male";
                }
                else if (f == "female" )
                {
                    user.gender ="Female";
                }

                user.username = name.Text;
                user.Password_ = pass.Text;
               
                if(age.Text.Length > 17)
                {
                    var a = int.Parse(age.Text);
                    user.age = a;
                }
              
                user.Phone = phone.Text;
                db.User_.Add(user);
                db.SaveChanges();
                Login login = new Login();  
                this.NavigationService.Navigate(login); 
   

            }
            else
            {
                MessageBox.Show("error kebeer");
            }
            
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.NavigationService.Navigate(login);
        }
    }
}
