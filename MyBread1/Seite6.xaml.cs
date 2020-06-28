using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Diagnostics;
using Windows.Services.Maps;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
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
            this.Frame.Navigate(typeof(Warenkorb), Bestellung4.Text); 
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
        public void AddSpaceNeedleIcon()
        {
            var MyLandmarks = new List<MapElement>();

            BasicGeoposition snPosition = new BasicGeoposition 
            { Latitude = 49.3007,
                Longitude = 10.5692 };
            Geopoint snPoint = new Geopoint(snPosition);

            var spaceNeedleIcon = new MapIcon
            {
                Location = snPoint,
                NormalizedAnchorPoint = new Point(0.5, 1.0),
                ZIndex = 0,
                Title = "Space Needle"
            };

            MyLandmarks.Add(spaceNeedleIcon);

            var LandmarksLayer = new MapElementsLayer
            {
                ZIndex = 1,
                MapElements = MyLandmarks
            };

            

        }

        private void Ansbach_Click(object sender, RoutedEventArgs e)
        {
            MapService.ServiceToken = "abcdef-abcdefghijklmno";
            Bestellung4.Text ="- Ansbach \r\n";
           
            Geopoint seattlePoint = new Geopoint
            (new BasicGeoposition
            {
                Latitude = 49.3007,
                Longitude = 10.5692
            });

            PlaceInfo spaceNeedlePlace = PlaceInfo.Create(seattlePoint);

            FrameworkElement targetElement = (FrameworkElement)sender;

            GeneralTransform generalTransform =
                targetElement.TransformToVisual((FrameworkElement)targetElement.Parent);

            Rect rectangle = generalTransform.TransformBounds(new Rect(new Point
                (targetElement.Margin.Bottom, targetElement.Margin.Top), targetElement.RenderSize));

            spaceNeedlePlace.Show(rectangle, Windows.UI.Popups.Placement.Below);
        }

 
        private void Fürth_Click(object sender, RoutedEventArgs e)
        {
            MapService.ServiceToken = "abcdef-abcdefghijklmno";
            Bestellung4.Text = "- Fürth \r\n";
          

            Geopoint seattlePoint = new Geopoint
           (new BasicGeoposition
           {
               Latitude = 49.4954,
               Longitude = 10.9444
           });

            PlaceInfo spaceNeedlePlace = PlaceInfo.Create(seattlePoint);

            FrameworkElement targetElement = (FrameworkElement)sender;

            GeneralTransform generalTransform =
                targetElement.TransformToVisual((FrameworkElement)targetElement.Parent);

            Rect rectangle = generalTransform.TransformBounds(new Rect(new Point
                (targetElement.Margin.Bottom, targetElement.Margin.Bottom), targetElement.RenderSize));

            spaceNeedlePlace.Show(rectangle, Windows.UI.Popups.Placement.Below);

        }

        
        private void Nürnberg_Click(object sender, RoutedEventArgs e)
        {
            MapService.ServiceToken = "abcdef-abcdefghijklmno";
            Bestellung4.Text = "- Nürnberg \r\n";
           

            Geopoint seattlePoint = new Geopoint
          (new BasicGeoposition
          {
              Latitude = 49.4741,
              Longitude = 11.1296
          });

            PlaceInfo spaceNeedlePlace = PlaceInfo.Create(seattlePoint);

            FrameworkElement targetElement = (FrameworkElement)sender;

            GeneralTransform generalTransform =
                targetElement.TransformToVisual((FrameworkElement)targetElement.Parent);

            Rect rectangle = generalTransform.TransformBounds(new Rect(new Point
                (targetElement.Margin.Top, targetElement.Margin.Top), targetElement.RenderSize));

            spaceNeedlePlace.Show(rectangle, Windows.UI.Popups.Placement.Below); 
        }

     
    }

    }
