using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Capture;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace MyBread1
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class Startseite : Page
    {
        public Startseite()
         {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }
        private void Navigiere_zuSeite1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Seite1));
        }
        
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var camera = new CameraCaptureUI();
            var storageFile = await camera.CaptureFileAsync(CameraCaptureUIMode.Photo);
            if (storageFile == null) return;
            using (var stream = await storageFile.OpenAsync(FileAccessMode.Read))
            {
                var bitmap = new BitmapImage();
                bitmap.SetSource(stream);
                Bild.Source = bitmap;
            }
        }

        private void Navigiere_zuInfos(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Infos));
        }
    }
} 
