﻿#pragma checksum "C:\Users\LENOVO\Desktop\Grupa12-TimWorthlessWithoutCoffee\DearWalletDressMeUp\DearWalletDressMeUp\View\Registracija.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AECDD9AB2954A781F24AF5CAB8A6EBA9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DearWalletDressMeUp
{
    partial class Registracija : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.Mobitel = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 2:
                {
                    this.Tablet = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 3:
                {
                    this.Desktop = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.Back = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 61 "..\..\..\View\Registracija.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Back).Click += this.Back_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.Glavni = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 6:
                {
                    this.Logo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 7:
                {
                    this.LicniPodaciRegistracija = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 8:
                {
                    this.Registruj = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 106 "..\..\..\View\Registracija.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Registruj).Click += this.Registruj_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.error = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.ime = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11:
                {
                    this.prezime = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12:
                {
                    this.username = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13:
                {
                    this.sifra = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 14:
                {
                    this.potvrdaSifre = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 15:
                {
                    this.adresa = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 16:
                {
                    this.telefon = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 17:
                {
                    this.kartica = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

