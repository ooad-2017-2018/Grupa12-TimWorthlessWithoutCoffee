﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace DearWalletDressMeUp
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
    private global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlTypeInfoProvider _provider;

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[23];
            _typeNameTable[0] = "DearWalletDressMeUp.AdminDodavanjeOdjece";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[2] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[3] = "DearWalletDressMeUp.AdminovProfil";
            _typeNameTable[4] = "DearWalletDressMeUp.AdminUserManagement";
            _typeNameTable[5] = "DearWalletDressMeUp.BackHomeLogout";
            _typeNameTable[6] = "DearWalletDressMeUp.Checkout";
            _typeNameTable[7] = "DearWalletDressMeUp.Home";
            _typeNameTable[8] = "DearWalletDressMeUp.Kreacija1";
            _typeNameTable[9] = "DearWalletDressMeUp.Kreacija2";
            _typeNameTable[10] = "DearWalletDressMeUp.Kreacija3";
            _typeNameTable[11] = "DearWalletDressMeUp.Kviz1";
            _typeNameTable[12] = "DearWalletDressMeUp.Kviz2";
            _typeNameTable[13] = "DearWalletDressMeUp.Kviz3";
            _typeNameTable[14] = "DearWalletDressMeUp.Login";
            _typeNameTable[15] = "DearWalletDressMeUp.MainPage";
            _typeNameTable[16] = "DearWalletDressMeUp.Poklon1";
            _typeNameTable[17] = "DearWalletDressMeUp.Poklon2";
            _typeNameTable[18] = "DearWalletDressMeUp.Poklon3";
            _typeNameTable[19] = "DearWalletDressMeUp.Poklon4";
            _typeNameTable[20] = "DearWalletDressMeUp.Pregled_profila";
            _typeNameTable[21] = "DearWalletDressMeUp.Pretraga";
            _typeNameTable[22] = "DearWalletDressMeUp.Registracija";

            _typeTable = new global::System.Type[23];
            _typeTable[0] = typeof(global::DearWalletDressMeUp.AdminDodavanjeOdjece);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[2] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[3] = typeof(global::DearWalletDressMeUp.AdminovProfil);
            _typeTable[4] = typeof(global::DearWalletDressMeUp.AdminUserManagement);
            _typeTable[5] = typeof(global::DearWalletDressMeUp.BackHomeLogout);
            _typeTable[6] = typeof(global::DearWalletDressMeUp.Checkout);
            _typeTable[7] = typeof(global::DearWalletDressMeUp.Home);
            _typeTable[8] = typeof(global::DearWalletDressMeUp.Kreacija1);
            _typeTable[9] = typeof(global::DearWalletDressMeUp.Kreacija2);
            _typeTable[10] = typeof(global::DearWalletDressMeUp.Kreacija3);
            _typeTable[11] = typeof(global::DearWalletDressMeUp.Kviz1);
            _typeTable[12] = typeof(global::DearWalletDressMeUp.Kviz2);
            _typeTable[13] = typeof(global::DearWalletDressMeUp.Kviz3);
            _typeTable[14] = typeof(global::DearWalletDressMeUp.Login);
            _typeTable[15] = typeof(global::DearWalletDressMeUp.MainPage);
            _typeTable[16] = typeof(global::DearWalletDressMeUp.Poklon1);
            _typeTable[17] = typeof(global::DearWalletDressMeUp.Poklon2);
            _typeTable[18] = typeof(global::DearWalletDressMeUp.Poklon3);
            _typeTable[19] = typeof(global::DearWalletDressMeUp.Poklon4);
            _typeTable[20] = typeof(global::DearWalletDressMeUp.Pregled_profila);
            _typeTable[21] = typeof(global::DearWalletDressMeUp.Pretraga);
            _typeTable[22] = typeof(global::DearWalletDressMeUp.Registracija);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_AdminDodavanjeOdjece() { return new global::DearWalletDressMeUp.AdminDodavanjeOdjece(); }
        private object Activate_3_AdminovProfil() { return new global::DearWalletDressMeUp.AdminovProfil(); }
        private object Activate_4_AdminUserManagement() { return new global::DearWalletDressMeUp.AdminUserManagement(); }
        private object Activate_5_BackHomeLogout() { return new global::DearWalletDressMeUp.BackHomeLogout(); }
        private object Activate_6_Checkout() { return new global::DearWalletDressMeUp.Checkout(); }
        private object Activate_7_Home() { return new global::DearWalletDressMeUp.Home(); }
        private object Activate_8_Kreacija1() { return new global::DearWalletDressMeUp.Kreacija1(); }
        private object Activate_9_Kreacija2() { return new global::DearWalletDressMeUp.Kreacija2(); }
        private object Activate_10_Kreacija3() { return new global::DearWalletDressMeUp.Kreacija3(); }
        private object Activate_11_Kviz1() { return new global::DearWalletDressMeUp.Kviz1(); }
        private object Activate_12_Kviz2() { return new global::DearWalletDressMeUp.Kviz2(); }
        private object Activate_13_Kviz3() { return new global::DearWalletDressMeUp.Kviz3(); }
        private object Activate_14_Login() { return new global::DearWalletDressMeUp.Login(); }
        private object Activate_15_MainPage() { return new global::DearWalletDressMeUp.MainPage(); }
        private object Activate_16_Poklon1() { return new global::DearWalletDressMeUp.Poklon1(); }
        private object Activate_17_Poklon2() { return new global::DearWalletDressMeUp.Poklon2(); }
        private object Activate_18_Poklon3() { return new global::DearWalletDressMeUp.Poklon3(); }
        private object Activate_19_Poklon4() { return new global::DearWalletDressMeUp.Poklon4(); }
        private object Activate_20_Pregled_profila() { return new global::DearWalletDressMeUp.Pregled_profila(); }
        private object Activate_21_Pretraga() { return new global::DearWalletDressMeUp.Pretraga(); }
        private object Activate_22_Registracija() { return new global::DearWalletDressMeUp.Registracija(); }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  DearWalletDressMeUp.AdminDodavanjeOdjece
                userType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_0_AdminDodavanjeOdjece;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  DearWalletDressMeUp.AdminovProfil
                userType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_3_AdminovProfil;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 4:   //  DearWalletDressMeUp.AdminUserManagement
                userType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_4_AdminUserManagement;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 5:   //  DearWalletDressMeUp.BackHomeLogout
                userType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.UserControl"));
                userType.Activator = Activate_5_BackHomeLogout;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 6:   //  DearWalletDressMeUp.Checkout
                userType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_6_Checkout;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 7:   //  DearWalletDressMeUp.Home
                userType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_7_Home;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 8:   //  DearWalletDressMeUp.Kreacija1
                userType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_8_Kreacija1;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 9:   //  DearWalletDressMeUp.Kreacija2
                userType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_9_Kreacija2;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 10:   //  DearWalletDressMeUp.Kreacija3
                userType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_10_Kreacija3;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 11:   //  DearWalletDressMeUp.Kviz1
                userType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_11_Kviz1;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 12:   //  DearWalletDressMeUp.Kviz2
                userType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_12_Kviz2;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 13:   //  DearWalletDressMeUp.Kviz3
                userType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_13_Kviz3;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 14:   //  DearWalletDressMeUp.Login
                userType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_14_Login;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 15:   //  DearWalletDressMeUp.MainPage
                userType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_15_MainPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 16:   //  DearWalletDressMeUp.Poklon1
                userType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_16_Poklon1;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 17:   //  DearWalletDressMeUp.Poklon2
                userType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_17_Poklon2;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 18:   //  DearWalletDressMeUp.Poklon3
                userType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_18_Poklon3;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 19:   //  DearWalletDressMeUp.Poklon4
                userType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_19_Poklon4;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 20:   //  DearWalletDressMeUp.Pregled_profila
                userType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_20_Pregled_profila;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 21:   //  DearWalletDressMeUp.Pretraga
                userType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_21_Pretraga;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 22:   //  DearWalletDressMeUp.Registracija
                userType = new global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_22_Registracija;
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }



        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlMember xamlMember = null;
            // No Local Properties
            return xamlMember;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlSystemBaseType
    {
        global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::DearWalletDressMeUp.DearWalletDressMeUp_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}

