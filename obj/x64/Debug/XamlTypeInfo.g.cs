﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace SmartAir
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
    private global::SmartAir.SmartAir_XamlTypeInfo.XamlTypeInfoProvider _provider;

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::SmartAir.SmartAir_XamlTypeInfo.XamlTypeInfoProvider();
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
                _provider = new global::SmartAir.SmartAir_XamlTypeInfo.XamlTypeInfoProvider();
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

namespace SmartAir.SmartAir_XamlTypeInfo
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
            _typeNameTable = new string[13];
            _typeNameTable[0] = "SmartAir.Common.BindablePage";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[2] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[3] = "XamlAnimatedGif.AnimationBehavior";
            _typeNameTable[4] = "Object";
            _typeNameTable[5] = "System.Uri";
            _typeNameTable[6] = "Windows.UI.Xaml.Controls.Image";
            _typeNameTable[7] = "System.IO.Stream";
            _typeNameTable[8] = "Windows.UI.Xaml.DependencyObject";
            _typeNameTable[9] = "Windows.UI.Xaml.Media.Animation.RepeatBehavior";
            _typeNameTable[10] = "Boolean";
            _typeNameTable[11] = "SmartAir.MainPage";
            _typeNameTable[12] = "String";

            _typeTable = new global::System.Type[13];
            _typeTable[0] = typeof(global::SmartAir.Common.BindablePage);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[2] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[3] = typeof(global::XamlAnimatedGif.AnimationBehavior);
            _typeTable[4] = typeof(global::System.Object);
            _typeTable[5] = typeof(global::System.Uri);
            _typeTable[6] = typeof(global::Windows.UI.Xaml.Controls.Image);
            _typeTable[7] = typeof(global::System.IO.Stream);
            _typeTable[8] = typeof(global::Windows.UI.Xaml.DependencyObject);
            _typeTable[9] = typeof(global::Windows.UI.Xaml.Media.Animation.RepeatBehavior);
            _typeTable[10] = typeof(global::System.Boolean);
            _typeTable[11] = typeof(global::SmartAir.MainPage);
            _typeTable[12] = typeof(global::System.String);
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

        private object Activate_11_MainPage() { return new global::SmartAir.MainPage(); }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::SmartAir.SmartAir_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::SmartAir.SmartAir_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  SmartAir.Common.BindablePage
                userType = new global::SmartAir.SmartAir_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::SmartAir.SmartAir_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::SmartAir.SmartAir_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  XamlAnimatedGif.AnimationBehavior
                userType = new global::SmartAir.SmartAir_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.AddMemberName("SourceUri");
                userType.AddMemberName("SourceStream");
                userType.AddMemberName("RepeatBehavior");
                userType.AddMemberName("AutoStart");
                userType.AddMemberName("AnimateInDesignMode");
                xamlType = userType;
                break;

            case 4:   //  Object
                xamlType = new global::SmartAir.SmartAir_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 5:   //  System.Uri
                userType = new global::SmartAir.SmartAir_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 6:   //  Windows.UI.Xaml.Controls.Image
                xamlType = new global::SmartAir.SmartAir_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 7:   //  System.IO.Stream
                userType = new global::SmartAir.SmartAir_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 8:   //  Windows.UI.Xaml.DependencyObject
                xamlType = new global::SmartAir.SmartAir_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 9:   //  Windows.UI.Xaml.Media.Animation.RepeatBehavior
                xamlType = new global::SmartAir.SmartAir_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 10:   //  Boolean
                xamlType = new global::SmartAir.SmartAir_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 11:   //  SmartAir.MainPage
                userType = new global::SmartAir.SmartAir_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("SmartAir.Common.BindablePage"));
                userType.Activator = Activate_11_MainPage;
                userType.AddMemberName("Minmsg");
                userType.AddMemberName("Maxmsg");
                userType.AddMemberName("TemperatureDisplay");
                userType.AddMemberName("HumidityDisplay");
                userType.AddMemberName("Pm25Display");
                userType.AddMemberName("LastUpdatedDisplay");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 12:   //  String
                xamlType = new global::SmartAir.SmartAir_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;
            }
            return xamlType;
        }


        private object get_0_AnimationBehavior_SourceUri(object instance)
        {
            return global::XamlAnimatedGif.AnimationBehavior.GetSourceUri((global::Windows.UI.Xaml.Controls.Image)instance);
        }
        private void set_0_AnimationBehavior_SourceUri(object instance, object Value)
        {
            global::XamlAnimatedGif.AnimationBehavior.SetSourceUri((global::Windows.UI.Xaml.Controls.Image)instance, (global::System.Uri)Value);
        }
        private object get_1_AnimationBehavior_SourceStream(object instance)
        {
            return global::XamlAnimatedGif.AnimationBehavior.GetSourceStream((global::Windows.UI.Xaml.DependencyObject)instance);
        }
        private void set_1_AnimationBehavior_SourceStream(object instance, object Value)
        {
            global::XamlAnimatedGif.AnimationBehavior.SetSourceStream((global::Windows.UI.Xaml.DependencyObject)instance, (global::System.IO.Stream)Value);
        }
        private object get_2_AnimationBehavior_RepeatBehavior(object instance)
        {
            return global::XamlAnimatedGif.AnimationBehavior.GetRepeatBehavior((global::Windows.UI.Xaml.DependencyObject)instance);
        }
        private void set_2_AnimationBehavior_RepeatBehavior(object instance, object Value)
        {
            global::XamlAnimatedGif.AnimationBehavior.SetRepeatBehavior((global::Windows.UI.Xaml.DependencyObject)instance, (global::Windows.UI.Xaml.Media.Animation.RepeatBehavior)Value);
        }
        private object get_3_AnimationBehavior_AutoStart(object instance)
        {
            return global::XamlAnimatedGif.AnimationBehavior.GetAutoStart((global::Windows.UI.Xaml.DependencyObject)instance);
        }
        private void set_3_AnimationBehavior_AutoStart(object instance, object Value)
        {
            global::XamlAnimatedGif.AnimationBehavior.SetAutoStart((global::Windows.UI.Xaml.DependencyObject)instance, (global::System.Boolean)Value);
        }
        private object get_4_AnimationBehavior_AnimateInDesignMode(object instance)
        {
            return global::XamlAnimatedGif.AnimationBehavior.GetAnimateInDesignMode((global::Windows.UI.Xaml.DependencyObject)instance);
        }
        private void set_4_AnimationBehavior_AnimateInDesignMode(object instance, object Value)
        {
            global::XamlAnimatedGif.AnimationBehavior.SetAnimateInDesignMode((global::Windows.UI.Xaml.DependencyObject)instance, (global::System.Boolean)Value);
        }
        private object get_5_MainPage_Minmsg(object instance)
        {
            var that = (global::SmartAir.MainPage)instance;
            return that.Minmsg;
        }
        private object get_6_MainPage_Maxmsg(object instance)
        {
            var that = (global::SmartAir.MainPage)instance;
            return that.Maxmsg;
        }
        private object get_7_MainPage_TemperatureDisplay(object instance)
        {
            var that = (global::SmartAir.MainPage)instance;
            return that.TemperatureDisplay;
        }
        private object get_8_MainPage_HumidityDisplay(object instance)
        {
            var that = (global::SmartAir.MainPage)instance;
            return that.HumidityDisplay;
        }
        private object get_9_MainPage_Pm25Display(object instance)
        {
            var that = (global::SmartAir.MainPage)instance;
            return that.Pm25Display;
        }
        private object get_10_MainPage_LastUpdatedDisplay(object instance)
        {
            var that = (global::SmartAir.MainPage)instance;
            return that.LastUpdatedDisplay;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::SmartAir.SmartAir_XamlTypeInfo.XamlMember xamlMember = null;
            global::SmartAir.SmartAir_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "XamlAnimatedGif.AnimationBehavior.SourceUri":
                userType = (global::SmartAir.SmartAir_XamlTypeInfo.XamlUserType)GetXamlTypeByName("XamlAnimatedGif.AnimationBehavior");
                xamlMember = new global::SmartAir.SmartAir_XamlTypeInfo.XamlMember(this, "SourceUri", "System.Uri");
                xamlMember.SetTargetTypeName("Windows.UI.Xaml.Controls.Image");
                xamlMember.SetIsAttachable();
                xamlMember.Getter = get_0_AnimationBehavior_SourceUri;
                xamlMember.Setter = set_0_AnimationBehavior_SourceUri;
                break;
            case "XamlAnimatedGif.AnimationBehavior.SourceStream":
                userType = (global::SmartAir.SmartAir_XamlTypeInfo.XamlUserType)GetXamlTypeByName("XamlAnimatedGif.AnimationBehavior");
                xamlMember = new global::SmartAir.SmartAir_XamlTypeInfo.XamlMember(this, "SourceStream", "System.IO.Stream");
                xamlMember.SetTargetTypeName("Windows.UI.Xaml.DependencyObject");
                xamlMember.SetIsAttachable();
                xamlMember.Getter = get_1_AnimationBehavior_SourceStream;
                xamlMember.Setter = set_1_AnimationBehavior_SourceStream;
                break;
            case "XamlAnimatedGif.AnimationBehavior.RepeatBehavior":
                userType = (global::SmartAir.SmartAir_XamlTypeInfo.XamlUserType)GetXamlTypeByName("XamlAnimatedGif.AnimationBehavior");
                xamlMember = new global::SmartAir.SmartAir_XamlTypeInfo.XamlMember(this, "RepeatBehavior", "Windows.UI.Xaml.Media.Animation.RepeatBehavior");
                xamlMember.SetTargetTypeName("Windows.UI.Xaml.DependencyObject");
                xamlMember.SetIsAttachable();
                xamlMember.Getter = get_2_AnimationBehavior_RepeatBehavior;
                xamlMember.Setter = set_2_AnimationBehavior_RepeatBehavior;
                break;
            case "XamlAnimatedGif.AnimationBehavior.AutoStart":
                userType = (global::SmartAir.SmartAir_XamlTypeInfo.XamlUserType)GetXamlTypeByName("XamlAnimatedGif.AnimationBehavior");
                xamlMember = new global::SmartAir.SmartAir_XamlTypeInfo.XamlMember(this, "AutoStart", "Boolean");
                xamlMember.SetTargetTypeName("Windows.UI.Xaml.DependencyObject");
                xamlMember.SetIsAttachable();
                xamlMember.Getter = get_3_AnimationBehavior_AutoStart;
                xamlMember.Setter = set_3_AnimationBehavior_AutoStart;
                break;
            case "XamlAnimatedGif.AnimationBehavior.AnimateInDesignMode":
                userType = (global::SmartAir.SmartAir_XamlTypeInfo.XamlUserType)GetXamlTypeByName("XamlAnimatedGif.AnimationBehavior");
                xamlMember = new global::SmartAir.SmartAir_XamlTypeInfo.XamlMember(this, "AnimateInDesignMode", "Boolean");
                xamlMember.SetTargetTypeName("Windows.UI.Xaml.DependencyObject");
                xamlMember.SetIsAttachable();
                xamlMember.Getter = get_4_AnimationBehavior_AnimateInDesignMode;
                xamlMember.Setter = set_4_AnimationBehavior_AnimateInDesignMode;
                break;
            case "SmartAir.MainPage.Minmsg":
                userType = (global::SmartAir.SmartAir_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SmartAir.MainPage");
                xamlMember = new global::SmartAir.SmartAir_XamlTypeInfo.XamlMember(this, "Minmsg", "String");
                xamlMember.Getter = get_5_MainPage_Minmsg;
                xamlMember.SetIsReadOnly();
                break;
            case "SmartAir.MainPage.Maxmsg":
                userType = (global::SmartAir.SmartAir_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SmartAir.MainPage");
                xamlMember = new global::SmartAir.SmartAir_XamlTypeInfo.XamlMember(this, "Maxmsg", "String");
                xamlMember.Getter = get_6_MainPage_Maxmsg;
                xamlMember.SetIsReadOnly();
                break;
            case "SmartAir.MainPage.TemperatureDisplay":
                userType = (global::SmartAir.SmartAir_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SmartAir.MainPage");
                xamlMember = new global::SmartAir.SmartAir_XamlTypeInfo.XamlMember(this, "TemperatureDisplay", "String");
                xamlMember.Getter = get_7_MainPage_TemperatureDisplay;
                xamlMember.SetIsReadOnly();
                break;
            case "SmartAir.MainPage.HumidityDisplay":
                userType = (global::SmartAir.SmartAir_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SmartAir.MainPage");
                xamlMember = new global::SmartAir.SmartAir_XamlTypeInfo.XamlMember(this, "HumidityDisplay", "String");
                xamlMember.Getter = get_8_MainPage_HumidityDisplay;
                xamlMember.SetIsReadOnly();
                break;
            case "SmartAir.MainPage.Pm25Display":
                userType = (global::SmartAir.SmartAir_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SmartAir.MainPage");
                xamlMember = new global::SmartAir.SmartAir_XamlTypeInfo.XamlMember(this, "Pm25Display", "String");
                xamlMember.Getter = get_9_MainPage_Pm25Display;
                xamlMember.SetIsReadOnly();
                break;
            case "SmartAir.MainPage.LastUpdatedDisplay":
                userType = (global::SmartAir.SmartAir_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SmartAir.MainPage");
                xamlMember = new global::SmartAir.SmartAir_XamlTypeInfo.XamlMember(this, "LastUpdatedDisplay", "String");
                xamlMember.Getter = get_10_MainPage_LastUpdatedDisplay;
                xamlMember.SetIsReadOnly();
                break;
            }
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
    internal class XamlUserType : global::SmartAir.SmartAir_XamlTypeInfo.XamlSystemBaseType
    {
        global::SmartAir.SmartAir_XamlTypeInfo.XamlTypeInfoProvider _provider;
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

        public XamlUserType(global::SmartAir.SmartAir_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
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
        global::SmartAir.SmartAir_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::SmartAir.SmartAir_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
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

