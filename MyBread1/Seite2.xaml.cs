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
        }
        private void Navigiere_zuSeite3(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Seite3));
            App app = (App)App.Current;
            app.Karotten = Bestellung2.Text;
            app.Speck = Bestellung2.Text;
            app.Tomaten = Bestellung2.Text;
            app.Cranberries = Bestellung2.Text;
            app.Paranüsse = Bestellung2.Text;
            app.Rosinen = Bestellung2.Text;
            app.SonnenK = Bestellung2.Text;
        }
        private void Navigiere_zuStart(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Startseite));
        }
        private void Navigiere_zuSeite1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Seite1));
        }
        private void Navigiere_zuWarenkorb(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Warenkorb));
        }

        private void Karotten_Click(object sender, RoutedEventArgs e)
        {
            Info2.Text = "Da Karotten überdies zu den Spitzenreitern der Carotinoidlieferanten zählen, sind sie ausserdem extrem gesund – insbesondere für die Augen, die Haut und das Herz. " +
                "Die leckeren Möhrchen sind trotz ihrer natürlichen Süsse also sehr kalorienarm.";
        }

        private void Speck_Click(object sender, RoutedEventArgs e)
        {
            Info2.Text = "Speck gilt als ergiebige Eiweisquelle. Verleiht dem Brot eine würzig, rauchige Note, und macht des Brot nebenbei noch unglaublich saftig. " +
                "Unser Speck kommt natürlich von glücklichen Kuhs aus biologischer Viehzucht.";
        }

        private void Tomaten_Click(object sender, RoutedEventArgs e)
        {
            Info2.Text = "Die ganzen getrockneten Tomaten besitzen einen hocharomatischen und fruchtigen Tomatengeschmack, der sofort mediterranes Flair aufkommen lässt." +
                "Für unsere getrockneten Tomaten wird nur etwas Salz verwendet, wir fügen keinerlei künstliche Geschmacksverstärker, Aromen oder Farbstoffe hinzu.";
        }

        private void Cranberries_Click(object sender, RoutedEventArgs e)
        {
            Info2.Text = "Cranberries sind ideal für eine Low Carb orientierte Diät, da sie eine Menge Nährstoffen, Ballaststoffe, und Antioxidantien  beinhalten. " +
                "Sie verleihen dem Brot außerdem eine süßliche Note, welche eine sehr intensive Geschmackskomposition kreiert. ";
        }

        private void Rosinen_Click(object sender, RoutedEventArgs e)
        {
            Info2.Text = "Rosinen sind ebenso wie die Cranberries eher ungewöhnlich in deftigem Brot, doch glauben sie uns wenn wir sagen das süß und deftig in diesem Fall eine gute Idee ist. "
                + "Gesund macht sie außerdem ihr hoher Mineralstoffgehalt.";
        }

        private void Paranüsse_Click(object sender, RoutedEventArgs e)
        {
            Info2.Text = "Eine Paranuss deckt bereits ihren Selen Bedarf für diesen Tag, Selen braucht ihr Körper um Schwermetalle zu binden und schützt somit vor Herz-Kreislauf-Erkrankungen."
                + "Im Brot verleiht die Paranuss diesen typisch intensiven nussigen Geschmack. ";
        }

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
