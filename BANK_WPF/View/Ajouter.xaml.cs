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
    /// Logique d'interaction pour Ajouter.xaml
    /// </summary>
    public partial class Ajouter : UserControl
    {
        public Ajouter()
        {
            InitializeComponent();
        }

        private void AjouterBtn_Click(object sender, RoutedEventArgs e)
        {
            bool valid = true;
            if (string.IsNullOrEmpty(nomBox.Text))
            {
                valid = false;
                lblErrNom.Content = "Champ invalide";
            }
            if (string.IsNullOrEmpty(prenomBox.Text))
            {
                valid = false;
                lblErrPrenom.Content = "Champ invalide";
            }
            if (string.IsNullOrEmpty(adresseBox.Text))
            {
                valid = false;
                lblErrAdresse.Content = "Champ invalide";
            }
            if (string.IsNullOrEmpty(dateNaissDate.Text))
            {
                valid = false;
                lblErrDateNaiss.Content = "Champ invalide";
            }
            if (string.IsNullOrEmpty(phoneBox.Text)||phoneBox.Text.Length!=10)
            {
                valid = false;
                lblErrPhone.Content = "Champ invalide";
            }
            if (valid)
            {
                CLIENTS cl = new CLIENTS() { NOM_CLIENT = nomBox.Text, PRENOM_CLIENT = prenomBox.Text, MAIL_CLIENT = adresseBox.Text, DATE_NAISS_CLIENT = dateNaissDate.DisplayDate, TELEPHONE_CLIENT=phoneBox.Text};
                using(BankAppEntities cx = new BankAppEntities())
                {
                    if (!cx.CLIENTS.ToList().Exists(x=>x.MAIL_CLIENT==cl.MAIL_CLIENT))
                    {
                    cx.CLIENTS.Add(cl);
                    cx.SaveChanges();
                    this.Content = new Accueil();
                    }
                    else lblErrAjout.Content = "Le client existe déjà";
                }
            }
        }

        private void retourBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Accueil();
        }
    }
}
