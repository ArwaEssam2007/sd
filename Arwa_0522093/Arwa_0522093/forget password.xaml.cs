using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace Arwa_0522093
{
    /// <summary>
    /// Interaction logic for forget_password.xaml
    /// </summary>
    public partial class forget_password : Page
    {
        facebookEntities1 db = new facebookEntities1();
        public forget_password()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           user user = new user();
            int ph = int.Parse(phonetxt.Text);
            user = db.users.First(x=>x.phone_number == ph);
            if(config.Text==newpass.Text)
            {
                user.user_password = newpass.Text;
                db.users.AddOrUpdate(user);
                db.SaveChanges();
                MessageBox.Show("password is saved");
            }


           

        }
    }
}
