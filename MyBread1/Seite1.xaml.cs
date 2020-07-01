using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace MyBread1
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    
    public sealed partial class Seite1 : Page
    {
        public Seite1()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        //Navigation zur nächsten Seite und Übergabe der Daten mit Hilfe einer globalen Variable
        //checkboxen und Textblock wird wieder auf null gesetzt
        private void Navigiere_zuSeite2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Seite2));
            App app = (App)App.Current;
            app.Mehl = Bestellung.Text;
            
            checkbox1.IsChecked = false;
            checkbox2.IsChecked = false;
            checkbox3.IsChecked = false;
            checkbox4.IsChecked = false;
            Bestellung.Text = "";
          
        }
       

        private void Navigiere_zuStart(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Startseite));
        }

 
        //// Informationen über einzelne Mehlsorten werden in der Infobox gespeichert
        private void Dinkel_Click(object sender, RoutedEventArgs e)
        {
            Info.Text = "Dinkelmehl: In keinem anderen Getreide stecken so viele gesunde Nährwerte wie im Dinkel."+
                " Dinkel ist das Urkorn des Weizens. Dinkelmehl ist das gemahlene Produkt des Dinkelkorns, entweder wird es als ganzes Korn gemahlen oder Teile davon. ";
            
        }

        private void Roggen_Click(object sender, RoutedEventArgs e)
        {
            Info.Text = "Roggenmehl: Wegen des vergleichsweise hohen Gehalts an der Aminosäure Lysin kann Roggen ein wichtiger Bestandteil einer ausgewogenen Ernährung sein." +
                "Brotprodukte aus Roggenmehl haben eine feinere Konsistenz als reine Vollkornbackwaren. Außerdem sind sie bei Kindern, aber auch bei älteren Verbrauchern beliebter.";
        }

        private void Kokos_Click(object sender, RoutedEventArgs e)
        {
            Info.Text = "Kokosmehl: Kokosmehl – fettarm, cholesterinfrei, geschmackvoll und ballaststoffreich" +
            "Das Mehl der Kokosnuss ist bestens bekömmlich für Menschen mit einem empfindlichen Verdauungssystem." + 
            "Kokosmehl enthält kein Gluten und ist daher für das Verdauungssystem eine erholsame Wohltat. Darüber hinaus ist Kokosmehl frei von Phytinsäure. GLUTENFREI";
        }

        private void Kamut_Click(object sender, RoutedEventArgs e)
        {
            Info.Text = "Kamutmehl: Kamutmehl wird aus dem sogenannten Khorasan-Weizen hergestellt, das als eine der ältesten Weizensorten der Welt gilt." +
         " Das Kamutmehl hat einen leicht süßlichen bis herzhaft-nussigen Geschmack und hat in der Ernährung eine besondere Qualität, weil es einen viel höheren Nährstoffgehalt als die bekannten Getreidearten aufweist. " ; 
        }

        //Festlegen und gegebenenfalls löschen des Ausgabetexts 
        private void Dinkel2_Click(object sender, RoutedEventArgs e)
        {
            Bestellung.Text += "- Dinkelmehl \r\n";
           
        }
        private void Dinkel2_Clickuncheck(object sender, RoutedEventArgs e)
        {
            Bestellung.Text = "";
        }

        private void Roggen2_Click(object sender, RoutedEventArgs e)
        {
            Bestellung.Text +="- Roggenmehl \r\n";
        }
        private void Roggen2_Clickuncheck(object sender, RoutedEventArgs e)
        {
            Bestellung.Text = "";
        }

        private void Kokos2_Click(object sender, RoutedEventArgs e)
        {
            Bestellung.Text +=  "- Kokosmehl \r\n";
        }

        private void Kokos2_Clickuncheck(object sender, RoutedEventArgs e)
        {

            Bestellung.Text ="";
        }

        private void Kamut2_Click(object sender, RoutedEventArgs e)
        {
            Bestellung.Text += "- Kamutmehl \r\n";
        }

        private void Kamut2_Clickuncheck(object sender, RoutedEventArgs e)
        {
            Bestellung.Text = "";
        }

       
    }
}
