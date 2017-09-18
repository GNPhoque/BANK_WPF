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
    /// Logique d'interaction pour Recherche.xaml
    /// </summary>
    public partial class Recherche : UserControl
    {
        public Recherche()
        {
            this.DataContext = this;
            InitializeComponent();
        }

        private void rechercherBtn_Click(object sender, RoutedEventArgs e)
        {
            List<CLIENTS> lRecherche = new List<CLIENTS>();
            if (string.IsNullOrEmpty(nomBox.Text) && string.IsNullOrEmpty(prenomBox.Text) && string.IsNullOrEmpty(adresseBox.Text) && string.IsNullOrEmpty(phoneBox.Text))
            {
                lblErrRecherche.Content = "Rensegner au moins un champ";
            }
            else
            {
                using (BankAppEntities cx = new BankAppEntities())
                {
                    //var req = from elt in cx.CLIENTS where (elt.NOM_CLIENT.Contains(nomBox.Text) && elt.PRENOM_CLIENT.Contains(prenomBox.Text) && elt.MAIL_CLIENT.Contains(adresseBox.Text) && elt.DATE_NAISS_CLIENT.ToString().Contains(dateNaissDate.DisplayDate.ToString()) && elt.TELEPHONE_CLIENT.Contains(phoneBox.Text)) select elt;
                    //if (req.Count() > 0)
                    //{

                    //    lblErrAjout.Content = "";
                    //    foreach (var item in req)
                    //    {
                    //        lRecherche.Add(item);
                    //    }
                    //}
                    //else
                    //{
                    //    lblErrAjout.Content = "Aucun résultat";
                    //}
                    var req = from elt in cx.CLIENTS where (elt.NOM_CLIENT.Contains(nomBox.Text) && elt.PRENOM_CLIENT.Contains(prenomBox.Text) && elt.MAIL_CLIENT.Contains(adresseBox.Text) && elt.TELEPHONE_CLIENT.Contains(phoneBox.Text)) select elt;
                    if (req.Count() > 0)
                    {

                        lblErrAjout.Content = "";
                        foreach (var item in req)
                        {
                            lRecherche.Add(item);
                        }
                    }
                    else
                    {
                        lblErrAjout.Content = "Aucun résultat";
                    }
                }
                grid.ItemsSource = lRecherche;
            }
        }

        private void retourBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Accueil();
        }
    }
}
