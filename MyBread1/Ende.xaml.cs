using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
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
    public sealed partial class Ende : Page
    {
        public Ende()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        //Navigation zurück zur Startseite
        //Setzen der globalen Variablen auf null
        private void Navigiere_zuStart(object sender, RoutedEventArgs e)
        {
            App app = (App)App.Current;
           
            this.Frame.Navigate(typeof(Startseite));
            button1 = false;
            Text_BNummer.Text = "";
        }
       
        private void Navigiere_zuWarenkorb(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Warenkorb));
        }
        
        //Initialisierung und Deklaration der Variable
        bool button1 = false;
        //Sicherstellung des einmaligen klickens durch if-Abfrage
        //Festlegung der Bestellnummer durch Next funktion in bestimmtem Zahlenraum
        private void BestellNummer(object sender, RoutedEventArgs e)
        {
            if (button1 == false)
            {
                button1 = true;
                Random rnd = new Random();
                Text_BNummer.Text = "Ihre Bestellnummer: " + rnd.Next(100, 999);
            }

        }
    }
}
