﻿#pragma checksum "..\..\..\..\Views\CreateDeviceView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A22A3165132BD56F99D0BA453F4D5396B37B6CA9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using OurDevices.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace OurDevices.Views {
    
    
    /// <summary>
    /// CreateDeviceView
    /// </summary>
    public partial class CreateDeviceView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\..\Views\CreateDeviceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DeviceName;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Views\CreateDeviceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AvailableDevices;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Views\CreateDeviceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DeviceType;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Views\CreateDeviceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AvailableIPAddress;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Views\CreateDeviceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MACAddress;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Views\CreateDeviceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Mobile;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Views\CreateDeviceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateDevice;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\Views\CreateDeviceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Update;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\Views\CreateDeviceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteDevice;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\Views\CreateDeviceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelCreation;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/OurDevices;component/views/createdeviceview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\CreateDeviceView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DeviceName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.AvailableDevices = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.DeviceType = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.AvailableIPAddress = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.MACAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Mobile = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.CreateDevice = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.Update = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.DeleteDevice = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.CancelCreation = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
