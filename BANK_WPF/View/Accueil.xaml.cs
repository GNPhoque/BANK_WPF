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
    /// Logique d'interaction pour Accueil.xaml
    /// </summary>
    public partial class Accueil : UserControl
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void ajouterBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Ajouter();
        }

        private void rechercherBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Recherche();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Connexion();
        }

        private void infosBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new InfosBanque();
        }

        private void docBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Documentation();
        }

        private void servicesBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Services();
        }
    }
}
