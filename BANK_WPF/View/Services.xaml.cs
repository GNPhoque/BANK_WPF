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

namespace BANK_WPF.View
{
    /// <summary>
    /// Logique d'interaction pour Services.xaml
    /// </summary>
    public partial class Services : UserControl
    {
        public Services()
        {
            InitializeComponent();
            serv sv = new serv();
            cbb.ItemsSource = sv.nom;
        }

        public class serv
        {
            public string[] nom={"Comptabilité","Sécurité","Maintenace"};
            public string[] tel = { "0101010101", "0101010102", "0101010103" };
            public string[] resp = { "LAMBERT Jean", "LAMBERT Jeanne", "LAMBERT Jeannette" };
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            serv sv = new serv();
            int index = cbb.SelectedIndex;
            lbl.Content = "Service : " + sv.nom[index] + "\n Tel : " + sv.tel[index] + "\nResponsable service : " + sv.resp[index];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Accueil();
        }
    }
}
