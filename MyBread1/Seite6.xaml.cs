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
        }
        
        public void CalendarDatePicker(object sender, RoutedEventArgs e)
        {
            DatePicker datePickerFor2020 = new DatePicker();
            InitializeComponent();
            datePickerFor2020.SelectedDate = DateTime.Today;
            CalendarEditingControl();
            
            
        }
        public DateTime MinDate {
            get { return MinDate; }
            set { MinDate = Today; } 
        }
        public DateTime MaxDate { set; get; }

        public void CalendarEditingControl()
        {
            this.MinDate = DateTime.Today;
            this.MaxDate = DateTime.Today.AddYears(1);
        }
        
        
    }
}
