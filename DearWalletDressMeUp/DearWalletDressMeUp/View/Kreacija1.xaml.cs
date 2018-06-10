﻿using System;
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
using DearWalletDressMeUp.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DearWalletDressMeUp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Kreacija1 : Page
    {
        private Korisnik _korLogin;
        public Kreacija1()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if(e.Parameter is Korisnik)
            {
                _korLogin = (Korisnik)e.Parameter;
            }
        }
        private void Homebtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Home),_korLogin);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Home),_korLogin);
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login));
        }

        private void MuskiOdjel_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Kreacija2),_korLogin);
        }

        private void ZenskiOdjel_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Kreacija2),_korLogin);
        }

        private void DjecijiOdjel_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Kreacija2),_korLogin);
        }

       
    }
}
