﻿#pragma checksum "C:\Users\defaultuser0\Desktop\Grupa12-TimWorthlessWithoutCoffee\DearWalletDressMeUp\DearWalletDressMeUp\AdminovProfil.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0AA8BCACE55A2103E7E1CFBCE5669A2E"
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
    partial class AdminovProfil : 
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
                    this.DodajBrisiKor = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 24 "..\..\..\AdminovProfil.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.DodajBrisiKor).Click += this.DodajBrisiKor_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.DodajOdj = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 25 "..\..\..\AdminovProfil.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.DodajOdj).Click += this.DodajOdj_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.Logout = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 4:
                {
                    this.Mobile = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.Tablet = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6:
                {
                    this.Desktop = (global::Windows.UI.Xaml.VisualState)(target);
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

