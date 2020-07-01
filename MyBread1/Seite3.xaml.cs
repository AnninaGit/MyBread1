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
    public sealed partial class Seite3 : Page
    {
        public Seite3()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        //Navigation zur nächsten Seite und Übergabe der Daten mit Hilfe einer globalen Variable
        private void Navigiere_zuSeite4(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Seite4));
            App app = (App)App.Current;
            app.Körner = Bestellung3.Text;
            checkbox1.IsChecked = false;
            checkbox2.IsChecked = false;
            checkbox3.IsChecked = false;
            checkbox4.IsChecked = false;
            checkbox5.IsChecked = false;
            checkbox6.IsChecked = false;
            Bestellung3.Text = "";

        }
        private void Navigiere_zuStart(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Startseite));
        }

        private void Navigiere_zuSeite2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Seite2));
        }

        private void Navigiere_zuWarenkorb(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Warenkorb));
        }

        // Informationen über einzelne Toppings werden in der Infobox3 gespeichert
        private void Körner_Click(object sender, RoutedEventArgs e)
        {
            Info3.Text = "Körner: Unser Körnermix setzt sich aus Sonnenblumenkernen und Kürbiskernen zusammen. "
                + "Kürbiskerne haben viele positive Wirkungen. Sie verbessern unter anderem die Cholesterinwerte und reduzieren Hautprobleme. " +
                "Und Sonnenblumenkerne liefern dem Körper Energie, sind reich an Proteinen und besitzen viele wichtige Vitamine und Nährstoffe.";
        }

        private void Nuss_Click(object sender, RoutedEventArgs e)
        {
            Info3.Text = "Nüsse: Unser Nussmix setzt sich aus Cashewnüssen, Walnüssen, Mandeln und Walnüssen zusammen"+
                "Neben den gesunden Fetten enthalten Nüsse auch hochwertiges Eiweiß, Ballaststoffe, sekundäre Pflanzenstoffe und sind eine gute Quelle für Vitamine und Mineralstoffe.";
        }

        private void RöstZ_Click(object sender, RoutedEventArgs e)
        {
            Info3.Text = "Röstwiebeln: Sie verleihen dem Brot eine pikante Note und machen das Brot von innen heraus knusprig.";
        }

        private void Walnuss_Click(object sender, RoutedEventArgs e)
        {
            Info3.Text = "Walnüsse: Sie sind Reich an Antioxidantien, Unterstützen die Gewichtskontrolle und helfen den Blutdruck zu senken.";
        }

        private void SonnenK_Click(object sender, RoutedEventArgs e)
        {
            Info3.Text = "Sonnenblumenkerne: Sie liefern dem Körper Energie, sind reich an Proteinen und besitzen viele wichtige Vitamine und Nährstoffe.";
        }

        private void Basilikum_Click(object sender, RoutedEventArgs e)
        {
            Info3.Text = "Basilikum: Der frische Basilikum verleiht dem Brot eine gewisse Frische und verleiht ihm einen dezenten Kräutergeschmack, ohne sich dabei zu sehr in den Vordergrund zu drängen. " +
                "Außerdem wirkt Basilikum entzündungshemmend und antioxidativ.";
        }

        // Festlegen und gegebenenfalls löschen des Ausgabetexts 
        private void Körner2_Click(object sender, RoutedEventArgs e)
        {
            Bestellung3.Text += "- Körnermix \r\n";
        }
        private void Körner2_Clickuncheck(object sender, RoutedEventArgs e)
        {
            Bestellung3.Text = "";
        }

        private void Nuss2_Click(object sender, RoutedEventArgs e)
        {
            Bestellung3.Text += "- Nussmix \r\n";
        }

        private void Nuss2_Clickuncheck(object sender, RoutedEventArgs e)
        {
            Bestellung3.Text = "";
        }

        private void RöstZ2_Click(object sender, RoutedEventArgs e)
        {
            Bestellung3.Text += "- Röstzwiebeln \r\n";
        }

        private void RöstZ2_Clickuncheck(object sender, RoutedEventArgs e)
        {
            Bestellung3.Text = "";
        }

        private void Walnuss2_Click(object sender, RoutedEventArgs e)
        {
            Bestellung3.Text += "- Walnuss \r\n";
        }

        private void Walnuss2_Clickuncheck(object sender, RoutedEventArgs e)
        {
            Bestellung3.Text = "";
        }

        private void SonnenK2_Click(object sender, RoutedEventArgs e)
        {
            Bestellung3.Text += "- Sonnenblumenkerne \r\n";
        }

        private void SonnenK2_Clickuncheck(object sender, RoutedEventArgs e)
        {
            Bestellung3.Text = "";
        }

        private void Basilikum2_Click(object sender, RoutedEventArgs e)
        {
            Bestellung3.Text += "- Basilikum \r\n";
        }

        private void Basilikum2_Clickuncheck(object sender, RoutedEventArgs e)
        {
            Bestellung3.Text = "";
        }
    }
}
