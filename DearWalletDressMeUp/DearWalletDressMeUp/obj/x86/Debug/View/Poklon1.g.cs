﻿#pragma checksum "C:\Users\LENOVO\Desktop\Grupa12-TimWorthlessWithoutCoffee\DearWalletDressMeUp\DearWalletDressMeUp\View\Poklon1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "64D6B0638B0C3EDB61214DA8AE49A814"
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
    partial class Poklon1 : 
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
                    this.stek = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 2:
                {
                    this.c = (global::Windows.UI.Xaml.Controls.ContentDialog)(target);
                    #line 32 "..\..\..\View\Poklon1.xaml"
                    ((global::Windows.UI.Xaml.Controls.ContentDialog)this.c).PrimaryButtonClick += this.c_PrimaryButtonClick;
                    #line 32 "..\..\..\View\Poklon1.xaml"
                    ((global::Windows.UI.Xaml.Controls.ContentDialog)this.c).SecondaryButtonClick += this.c_SecondaryButtonClick;
                    #line default
                }
                break;
            case 3:
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 28 "..\..\..\View\Poklon1.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.button_Click;
                    #line default
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

