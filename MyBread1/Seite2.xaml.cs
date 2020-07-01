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
    
    public sealed partial class Seite2 : Page
    {
        public Seite2()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            checkbox1.IsChecked = false;
        }

        //Navigation zur nächsten Seite und Übergabe der Daten mit Hilfe einer globalen Variable
        private void Navigiere_zuSeite3(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Seite3));
            App app = (App)App.Current;
            app.Karotten = Bestellung2.Text;
            checkbox1.IsChecked = false;
            checkbox2.IsChecked = false;
            checkbox3.IsChecked = false;
            checkbox4.IsChecked = false;
            checkbox5.IsChecked = false;
            checkbox6.IsChecked = false;
            Bestellung2.Text = "";

        }
        private void Navigiere_zuStart(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Startseite));
        }
        private void Navigiere_zuSeite1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Seite1));
        }
       

        // Informationen über einzelne Teigzusätze werden in der Infobox2 gespeichert
        private void Karotten_Click(object sender, RoutedEventArgs e)
        {
            Info2.Text = "Karotten: Da Karotten überdies zu den Spitzenreitern der Carotinoidlieferanten zählen, sind sie außerdem extrem gesund – insbesondere für die Augen, die Haut und das Herz. " +
                "Die leckeren Möhrchen sind trotz ihrer natürlichen Süße also sehr kalorienarm.";
        }

        private void Speck_Click(object sender, RoutedEventArgs e)
        {
            Info2.Text = "Speck: Speck gilt als ergiebige Eiweisquelle. Verleiht dem Brot eine würzige, rauchige Note und macht das Brot nebenbei noch unglaublich saftig. " +
                "Unser Speck kommt natürlich von glücklichen Kuhs aus biologischer Viehzucht.";
        }

        private void Tomaten_Click(object sender, RoutedEventArgs e)
        {
            Info2.Text = "getrocknete Tomaten: Die ganzen getrockneten Tomaten besitzen einen hocharomatischen und fruchtigen Tomatengeschmack, der sofort mediteranes Flair aufkommen lässt." +
                "Für unsere getrockneten Tomaten wird nur etwas Salz verwendet, wir fügen keinerlei künstliche Geschmacksverstärker, Aromen oder Farbstoffe hinzu.";
        }

        private void Cranberries_Click(object sender, RoutedEventArgs e)
        {
            Info2.Text = "Cranberries: Cranberries sind ideal für eine Low Carb orientierte Diät, da sie eine Menge Nährstoffe, Ballaststoffe, und Antioxidantien  beinhalten. " +
                "Sie verleihen dem Brot außerdem eine süßliche Note, welche eine sehr intensive Geschmackskomposition kreiert. ";
        }

        private void Rosinen_Click(object sender, RoutedEventArgs e)
        {
            Info2.Text = "Rosinen: Rosinen sind ebenso wie die Cranberries eher ungewöhnlich in deftigem Brot, doch glauben sie uns wenn wir sagen, dass süß und deftig in diesem Fall eine gute Idee ist. "
                + "Gesund macht sie außerdem ihr hoher Mineralstoffgehalt.";
        }

        private void Paranüsse_Click(object sender, RoutedEventArgs e)
        {
            Info2.Text = "Paranüsse: Eine Paranuss deckt bereits ihren Selen Bedarf für diesen Tag. Selen braucht ihr Körper um Schwermetalle zu binden und schützt somit vor Herz-Kreislauf-Erkrankungen."
                + "Im Brot verleiht die Paranuss diesen typisch intensiven nussigen Geschmack. ";
        }

        // Festlegen und gegebenenfalls löschen des Ausgabetexts 
        private void Karotten2_Click(object sender, RoutedEventArgs e)
        {
            Bestellung2.Text +=  "- Karotten \r\n" ;
        }
        private void Karotten2_Clickuncheck(object sender, RoutedEventArgs e)
        {
            Bestellung2.Text = "";
        }

        private void Speck2_Click(object sender, RoutedEventArgs e)
        {
            Bestellung2.Text += "- Speck \r\n";
        }
        private void Speck2_Clickuncheck(object sender, RoutedEventArgs e)
        {
            Bestellung2.Text = "";
        }

        private void Tomaten2_Click(object sender, RoutedEventArgs e)
        {
            Bestellung2.Text += "- getrocknete Tomaten \r\n";
        }
        private void Tomaten2_Clickuncheck(object sender, RoutedEventArgs e)
        {
            Bestellung2.Text = "";
        }

        private void Cranberries2_Click(object sender, RoutedEventArgs e)
        {
            Bestellung2.Text += "- Cranberries \r\n";
        }
        private void Cranberries2_Clickuncheck(object sender, RoutedEventArgs e)
        {
            Bestellung2.Text = "";
        }

        private void Paranüsse2_Click(object sender, RoutedEventArgs e)
        {
            Bestellung2.Text += "- Paranüsse \r\n";
        }
        private void Paranüsse2_Clickuncheck(object sender, RoutedEventArgs e)
        {
            Bestellung2.Text = "";
        }

        private void Rosinen2_Click(object sender, RoutedEventArgs e)
        {
            Bestellung2.Text += "- Rosinen \r\n";
        }
        private void Rosinen2_Clickuncheck(object sender, RoutedEventArgs e)
        {
            Bestellung2.Text = "";
        }

       
    }
}
