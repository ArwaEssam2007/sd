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
    /// Interaction logic for Delete.xaml
    /// </summary>
    public partial class Delete : Page
    {
        facebookEntities1 db = new facebookEntities1();
        public Delete()
        {
            InitializeComponent();
            dg2.ItemsSource=db.users.ToList();
        }

     

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            user user = new user();
            int ph = int.Parse(phonetxt.Text);
            user = db.users.Remove(db.users.FirstOrDefault(x => x.phone_number == ph));

          //  user = db.users.FirstOrDefault((x => x.phone_number == ph);
           // db.users.Remove(user);
            db.SaveChanges();
            MessageBox.Show("Record Deleted Succ");
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            dg2.ItemsSource = db.users.ToList();
        }
    }
}
