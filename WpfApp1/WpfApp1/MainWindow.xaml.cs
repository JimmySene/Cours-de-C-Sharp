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

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> listeDemandeurs = new List<Person>();
        List<Person> listeParticipants = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();

            
            Person perso1 = new Person("SENE", "Jimmy", 1);
            Person perso2 = new Person("LAMBERT", "Vincent", 2);
            Person perso3 = new Person("SULPICE", "Rémy", 3);

            listeDemandeurs.Add(perso1);
            listeDemandeurs.Add(perso2);
            listeDemandeurs.Add(perso3);

            TableauDemandeurs.ItemsSource = listeDemandeurs;
            TableauParticipants.ItemsSource = listeParticipants;
        }

        public void fleche_droite()
        {
            Person personneSelect = (Person)TableauDemandeurs.SelectedItem;
            if(personneSelect != null)
            {
                listeParticipants.Add(personneSelect);
                listeDemandeurs.Remove(personneSelect);
                TableauDemandeurs.Items.Refresh();
                TableauParticipants.Items.Refresh();
            }
            
        }

        public void fleche_gauche()
        {
            Person personneSelect = (Person)TableauParticipants.SelectedItem;
            if(personneSelect != null)
            {
                listeDemandeurs.Add(personneSelect);
                listeParticipants.Remove(personneSelect);
                TableauParticipants.Items.Refresh();
                TableauDemandeurs.Items.Refresh();
            }
            
        }
        private void btn_fleche_droite_Click(object sender, RoutedEventArgs e)
        {
            fleche_droite();
        }

        private void btn_fleche_gauche_Click(object sender, RoutedEventArgs e)
        {
            fleche_gauche();
        }
    }
}
