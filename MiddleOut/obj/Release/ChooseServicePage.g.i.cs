﻿#pragma checksum "..\..\ChooseServicePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8CBF2E17603D97D9A284928BA86454BD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Converters;
using FirstFloor.ModernUI.Windows.Navigation;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace MiddleOut {
    
    
    /// <summary>
    /// BasicPage1
    /// </summary>
    public partial class BasicPage1 : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\ChooseServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid HeadingGrid;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ChooseServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid RadioButtonGrid;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ChooseServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SelectServiceGrid;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ChooseServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton DriverRadioButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ChooseServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton DonateRadioButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\ChooseServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton EducateRadioButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ChooseServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RequestGoodsButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\ChooseServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ButtonGrid;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\ChooseServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nextPage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MiddleOut;component/chooseservicepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ChooseServicePage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.HeadingGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.RadioButtonGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.SelectServiceGrid = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.DriverRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.DonateRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.EducateRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.RequestGoodsButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.ButtonGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.nextPage = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\ChooseServicePage.xaml"
            this.nextPage.Click += new System.Windows.RoutedEventHandler(this.nextPage_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
