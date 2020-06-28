using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Diagnostics;
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
    public sealed partial class Seite6 : Page
    {
        public Seite6()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }
        private void Navigiere_zuStart(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Startseite));
            
        }

        private void Navigiere_zuSeite5(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Seite4));
        }
        private void Navigiere_zuWarenkorb(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Warenkorb));
            App app = (App)App.Current;
            app.Standort = Bestellung4.Text;
            app.Standort2 = Bestellung4.Text;
            app.Standort3 = Bestellung4.Text;
        }
       


        public DateTime MinDate {
            get;
            set;
        }
        public DateTime MaxDate { set; get; }

        public void CalendarEditingControl()
        {
            this.MinDate = DateTime.Today;
            this.MaxDate = DateTime.Today.AddYears(1);
        }

        private void Ansbach_Checked(object sender, RoutedEventArgs e)
        {
            Bestellung4.Text = "- Ansbach \r\n";
        }

        private void Ansbach_Unchecked(object sender, RoutedEventArgs e)
        {
            Bestellung4.Text = "";
        }
        private void Fürth_Checked(object sender, RoutedEventArgs e)
        {
            Bestellung4.Text = "- Fürth \r\n";
        }

        private void Fürth_Unchecked(object sender, RoutedEventArgs e)
        {
            Bestellung4.Text = "";
        }
        private void Nürnberg_Checked(object sender, RoutedEventArgs e)
        {
            Bestellung4.Text = "- Nürnberg \r\n";
        }

        private void Nürnberg_Unchecked(object sender, RoutedEventArgs e)
        {
            Bestellung4.Text = "";
        }

        private void textBox4_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            DateTime date = DateTime.Now;
            Bestellung4.Text = date.ToString();
        }
    }

    }
