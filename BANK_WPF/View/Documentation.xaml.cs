using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Logique d'interaction pour Documentation.xaml
    /// </summary>
    public partial class Documentation : UserControl
    {
        public Documentation()
        {
            InitializeComponent();
            ObservableCollection<string> lFichier = new ObservableCollection<string>();
            lFichier.Add("document.pdf");
            lFichier.Add("test.docx");
            cbb.ItemsSource = lFichier;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            System.Diagnostics.Process.Start(@".\..\..\Resources\"+cbb.SelectedItem);
        }

        private void retour_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Accueil();
        }
    }
}
