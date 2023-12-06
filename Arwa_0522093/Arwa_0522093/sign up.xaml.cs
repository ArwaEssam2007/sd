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

namespace Arwa_0522093
{
    /// <summary>
    /// Interaction logic for sign_up.xaml
    /// </summary>
    public partial class sign_up : Page
    {
        facebookEntities1 db = new facebookEntities1();
        string gender;
        public sign_up()
        {
            InitializeComponent();
        }
       bool invalied(string pass)
           {
            bool upper, lower, num, spc;
            upper = lower = num = spc = false;
            string spcial = "!@#$&*";
            foreach(char c in pass)
            {
                if (c>='A' && c<='Z')
                {
                    upper = true;
                }
               else if (c >= 'a' && c <= 'z')
                {
                   lower = true;
                }
               
               else if (c >= '1' && c <= '9')
                {
                    num = true;
                }
              
               else if (spcial.Contains(c))
                {
                   spc = true;
                }
            }
            return upper && lower && num && spc;
        }
       
       
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if ( invalied(passwordtxt.Text))

            {
                int phone =int.Parse(phonenumbertxt.Text);
                user user1 = new user();

                user1.users_name = usernametxt.Text;
                user1.user_password = passwordtxt.Text;
                user1.age= int.Parse(agetxt.Text);
                user1.Gender = gender;
                user1.phone_number = phone;
                user1.city = citycb.Text;
                db.users.Add(user1);
                db.SaveChanges();
                profail profail = new profail(user1);
                this.NavigationService.Navigate(profail);


            }
            else
            {
                MessageBox.Show("Password Is Not Valid");
            }
           
        }

        private void agetxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           sign_in sign_In = new sign_in();
            this.NavigationService.Navigate(sign_In);
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            gender = "Male";
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            gender = "Female";
        }
    }
}
