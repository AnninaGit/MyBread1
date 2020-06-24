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

        private void Navigiere_zuSeite6(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Seite6));
        }
        private void Navigiere_zuStart(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Startseite));
        }

        private void Navigiere_zuEnde(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Ende));
        }
        private void Bestellung_Ende(object sender, RoutedEventArgs e)
        {
            showDialog("Vielen Dank!");
            this.Frame.Navigate(typeof(Ende));
        }

        private async void showDialog(string Meldung)
        {
            var title = "Ihre Bestellung wurde erfolgreich übermittelt.";
            var Dialogfenster = new Windows.UI.Popups.MessageDialog(title, Meldung);
            await Dialogfenster.ShowAsync();

        }

        private void Navigiere_zuSeite1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Seite1));
        }
        private void Navigiere_zuSeite2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Seite2));
        }
        private void Navigiere_zuSeite3(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Seite3));
        }
        private void Navigiere_zuSeite4(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Seite4));
        }
        private void Navigiere_zuSeite5(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Seite5));
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        //    string uebernahmedaten = e.Parameter as string;
         //   if (!string.IsNullOrWhiteSpace(uebernahmedaten))
         //   {
         /*       Ausgabebox5.Text = "Extrawünsche: " + uebernahmedaten;
                Ausgabebox4.Text = "Spezifikationen: " + uebernahmedaten;

            }
            else
            {
                Ausgabebox5.Text = "Bitte auf den Änderungsbutton klicken";
                Ausgabebox4.Text = "Bitte auf den Änderungsbutton klicken";
            }
          base.OnNavigatedTo(e);
 */ 
            App app = (App)App.Current;
            Ausgabebox5.Text = app.globalertext;
            Ausgabebox4.Text = app.allgemeinertext;
            Ausgabebox1.Text = app.Mehl;
            Ausgabebox1.Text = app.Roggen;
            Ausgabebox1.Text = app.Kokos;
            Ausgabebox1.Text = app.Kamut;
            Ausgabebox2.Text = app.Karotten;
            Ausgabebox2.Text = app.Speck;
            Ausgabebox2.Text = app.Tomaten;
            Ausgabebox2.Text = app.Cranberries;
            Ausgabebox2.Text = app.Paranüsse;
            Ausgabebox2.Text = app.Rosinen;
            Ausgabebox3.Text = app.Körner;
            Ausgabebox3.Text = app.Nuss;
            Ausgabebox3.Text = app.Röst;
            Ausgabebox3.Text = app.Walnuss;
            Ausgabebox3.Text = app.SonnenK;
            Ausgabebox3.Text = app.Basilikum;





        }




    }


}
