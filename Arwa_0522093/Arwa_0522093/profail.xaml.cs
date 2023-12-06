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

namespace Arwa_0522093
{
    /// <summary>
    /// Interaction logic for profail.xaml
    /// </summary>
    public partial class profail : Page
    {
        user user = new user(); 
        public profail(user user)
        {
            InitializeComponent();
            username.Text = user.users_name;
            password.Password = user.user_password;
            age.Text = user.age.ToString();
            gender.Text = user.Gender;
            phone.Text=user.phone_number.ToString();
            city.Text=user.city;
        }
        facebookEntities1 db = new facebookEntities1();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           sign_in sign_In = new sign_in();
            this.NavigationService.Navigate(sign_In);
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
      
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
         
        }

        private void username_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
//