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
    public sealed partial class Seite4 : Page
    {
        public Seite4()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        //Navigation zur nächsten Seite und Übergabe der Daten mit Hilfe zweier globalen Variablen
        private void Navigiere_zuSeite5(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Seite5));
            App app = (App)App.Current;
            app.allgemeinertext = "Spezifikationen: \r\n" + Ausgabetext.Text;
            app.Herz = Bestellung4.Text;
        }

        private void Navigiere_zuStart(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Startseite));
        }
        private void Navigiere_zuSeite3(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Seite3));
        }
        private void Navigiere_zuWarenkorb(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Warenkorb));
        }

        //if-else Abfrage 
        private void ToggleSwitch(object sender, RoutedEventArgs e)
        {
            if ((bool)TogSwitch.IsOn)
            {
                  Ausgabetext.Text = "Ihr Brot wird für sie geschnitten \r\n";
            }
            else
            {
                  Ausgabetext.Text = "Ihr Brot bleibt ganz \r\n";
            }
        }

        //Festlegen der textuellen Ausgabe in der Bestellübersicht
        private void Herz_Click(object sender, RoutedEventArgs e)
        {
            Bestellung4.Text = "- Herzform \r\n";
        }

        private void Rund_Click(object sender, RoutedEventArgs e)
        {
            Bestellung4.Text = "- Rund \r\n";
        }

        private void Kasten_Click(object sender, RoutedEventArgs e)
        {
            Bestellung4.Text = "- Kasten \r\n";
        }
    }
}
