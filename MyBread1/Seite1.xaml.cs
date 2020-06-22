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
        private void Navigiere_zuSeite2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Seite2));
        }

        private void Navigiere_zuStart(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Startseite));
        }

        private void Navigiere_zuWarenkorb(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Warenkorb));
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            App app = (App)App.Current;
         //   Mehlbox.Text = app.globalertext;
        }

        private void ListView1_ItemClick(object sender, ItemClickEventArgs e)
        {
            App app = (App)App.Current;
         //   ItemClickEventArgs = app.globalertext;
        }

        private void Dinkel_Click(object sender, RoutedEventArgs e)
        {
            Info.Text = "Dinkelnmehl: In keinem anderen Getreide stecken so viele gesunde Nährwerte wie im Dinkel."+
                " Dinkel ist das Urkorn des Weizens. Dinkelmehl ist das gemahlene Produkt des Dinkelkorns, entweder wird es als ganzes Korn gemahlen oder Teile davon. ";
        }

        private void Roggen_Click(object sender, RoutedEventArgs e)
        {
            Info.Text = "Roggennmehl: Wegen des vergleichsweise hohen Gehalts an der Aminosäure Lysin kann Roggen ein wichtiger Bestandteil einer ausgewogenen Ernährung sein." +
                "Brotprodukte aus Roggenmehl haben eine feinere Konsistenz als reine Vollkornbackwaren. Außerdem sind sie bei Kindern, aber auch bei älteren Verbrauchern beliebter.";
        }

        private void Kokos_Click(object sender, RoutedEventArgs e)
        {
            Info.Text = "Kokosnmehl: Kokosmehl – fettarm, cholesterinfrei, geschmackvoll und ballaststoffreich" +
            "Das Mehl der Kokosnuss ist bestens bekömmlich für Menschen mit einem empfindlichen Verdauungssystem." + 
            "Kokosmehl enthält kein Gluten und ist daher für das Verdauungssystem eine erholsame Wohltat. Darüber hinaus ist Kokosmehl frei von Phytinsäure.";
        }

        private void Kamut_Click(object sender, RoutedEventArgs e)
        {
            Info.Text = "Kamutnmehl: Kamutmehl wird aus dem sogenannten Khorasan-Weizen hergestellt, der als eine der ältesten Weizensorten der Welt gilt." +
         " Das Kamutmehl hat einen leicht süßlichen bis herzhaft-nussigen Geschmack und hat in der Ernährung eine besondere Qualität, weil es einen viel höheren Nährstoffgehalt als die bekannten Getreidearten aufweist. " ; 
        }

      
    }
}
