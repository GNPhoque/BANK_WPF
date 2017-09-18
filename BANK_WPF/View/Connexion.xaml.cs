using BANK_WPF.Model.DB;
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
    /// Logique d'interaction pour Connexion.xaml
    /// </summary>
    public partial class Connexion : UserControl
    {

        BankAppEntities cx = new BankAppEntities();
        public Connexion()
        {
            InitializeComponent();
        }

        private void validerBtn_Click(object sender, RoutedEventArgs e)
        {
            if (cx.USERS.ToList().Exists(x => x.LOGIN == loginBox.Text))
            {
                USERS user = cx.USERS.Single(x => x.LOGIN == loginBox.Text);
                if (passBox.Password == user.PASSWORD)
                {
                    this.Content = new Accueil();
                }
            }

        }
    }
}
