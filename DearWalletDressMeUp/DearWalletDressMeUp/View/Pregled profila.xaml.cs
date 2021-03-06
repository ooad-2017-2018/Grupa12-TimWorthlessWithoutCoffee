﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using DearWalletDressMeUp.Model;
using Microsoft.WindowsAzure.MobileServices;
using DearWalletDressMeUp.ViewModel;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DearWalletDressMeUp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Pregled_profila : Page
    {
        private IMobileServiceTable<Korisnik> tabela = App.MobileService.GetTable<Korisnik>();
        private Korisnik _korLogin;

        public Pregled_profila()
        {
            this.InitializeComponent();
            DataContext = new ProfilViewModel();

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter is Korisnik)
            {
                _korLogin = (Korisnik)e.Parameter;
            }
            try
            {
                Korisnik kor = _korLogin;
                LicniImeText.Text = kor.Ime;
                LicniPrezimeText.Text = kor.Prezime;
                UsernameText.Text = kor.Id.ToString();
                Pass.Password = kor.Sifra;
                EmailText.Text = kor.Email;
                LicniAdresaText.Text = kor.Adresa;
                LicniTelefonText.Text = kor.BrojTel.ToString();
                Kreditna.Text = kor.BrojKreditneKartice.ToString();
            }
            catch (Exception)
            { }
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Home),_korLogin);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Home),_korLogin);
        }

        private void PreporuciPrijatelju_Click(object sender, RoutedEventArgs e)
        {

        }
        

        private  void IzmijeniLicne_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private async void IzmijeniSliku_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker fop = new FileOpenPicker();
            fop.FileTypeFilter.Add(".jpg");
            fop.FileTypeFilter.Add(".png");
            fop.FileTypeFilter.Add(".jpeg");
            StorageFile file = await fop.PickSingleFileAsync();
            if (file != null)
            {
                var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
                var image = new BitmapImage();
                image.SetSource(stream);
                userSlika.Source = image;
            }
        }

        private void BrisanjeProfila_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DodajKorpica_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Checkout),_korLogin);
        }

        private void DodajKreaciju_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Kreacija1),_korLogin);
        }

        private void DodajUKorpicu_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
