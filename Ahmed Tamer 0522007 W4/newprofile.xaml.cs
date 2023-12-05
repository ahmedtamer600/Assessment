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
using System.Xml.Linq;

namespace Assessment_Ahmed_tamer
{
    /// <summary>
    /// Interaction logic for newprofile.xaml
    /// </summary>
    public partial class newprofile : Page
    {
        instaEntities db = new instaEntities();
        public newprofile(string name)
        {
            InitializeComponent();
            lab.Content = "Welcome" + name;
            datagrid.ItemsSource = db.User_.Where(x => x.username == name).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.NavigationService.Navigate(login);
        }
    }
}
