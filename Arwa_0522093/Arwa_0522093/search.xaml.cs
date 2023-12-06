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
    /// Interaction logic for search.xaml
    /// </summary>
    public partial class search : Page
    {
        facebookEntities1 db = new facebookEntities1();
        public search()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            user user = new user();
            int ph = int.Parse(phonenumber.Text);
            dg1.ItemsSource = db.users.Where(x => x.phone_number == ph).ToList();
;

        }

        private void dg1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dg1.ItemsSource = db.users.ToList();
        }
    }
}
