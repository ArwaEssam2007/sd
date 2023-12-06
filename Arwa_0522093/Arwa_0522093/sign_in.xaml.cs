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
    /// Interaction logic for sign_in.xaml
    /// </summary>
    public partial class sign_in : Page
    {
        public sign_in()
        {
            InitializeComponent();
        }
        facebookEntities1 db = new facebookEntities1();

        private void Button_Click(object sender, RoutedEventArgs e)
        {

          user user = new user();
            if (comboboxname.Text == "user")
            {
                user = db.users.First(x => x.users_name == usernametxt.Text );
                if (user.users_name == usernametxt.Text && user.user_password == passtxt.Password)
                {
                    profail profail = new profail(user);
                    this.NavigationService.Navigate(profail);
                }

               else if (comboboxname.Text == "Admin")
                {
                    Adminn adminn = new Adminn();
                    this.NavigationService.Navigate(adminn);
                }

            }
        }




        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sign_up sign_Up = new sign_up();
            this.NavigationService.Navigate(sign_Up);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           forget_password forget_Password = new forget_password();
            this.NavigationService.Navigate(forget_Password);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Delete delete = new Delete();
            this.NavigationService.Navigate(delete);    
        }

        private void comboboxname_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
