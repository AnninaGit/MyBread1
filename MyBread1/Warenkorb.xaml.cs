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
    public sealed partial class Warenkorb : Page
    {
        public Warenkorb()
        {
            this.InitializeComponent();
        }
        int anzahl = 1;
        private void Zaehler(object Sender, RoutedEventArgs e)
        {
            Ausgabetext.Text = "Anzahl an Broten: " + (++anzahl).ToString();
        }
        private void Zaehler1(object Sender, RoutedEventArgs e)
        {
            if(anzahl > 1) 
            {Ausgabetext.Text = "Anzahl an Broten: " + (--anzahl).ToString(); }
            
        }

        private void Navigiere_zuSeite5(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Seite5));
        }
        private void Navigiere_zuStart(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Startseite));
        }

        private void Navigiere_zuEnde(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Ende));
        }
    }


}
