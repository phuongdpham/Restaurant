﻿#pragma checksum "..\..\AddOrder.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CA0EE0854FCEA5A9128C73C25D36F71C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace RestaurantManager1 {
    
    
    /// <summary>
    /// AddOrder
    /// </summary>
    public partial class AddOrder : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox tableNoCB;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridMenu;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn stt;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn nameCol;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn price;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox orderTB;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addOrder;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mainPage;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button finishOrder;
        
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
            System.Uri resourceLocater = new System.Uri("/RestaurantManager1;component/addorder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddOrder.xaml"
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
            this.tableNoCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.gridMenu = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.stt = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.nameCol = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.price = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.orderTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.addOrder = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\AddOrder.xaml"
            this.addOrder.Click += new System.Windows.RoutedEventHandler(this.addOrder_Cliked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.mainPage = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\AddOrder.xaml"
            this.mainPage.Click += new System.Windows.RoutedEventHandler(this.mainPage_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.finishOrder = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\AddOrder.xaml"
            this.finishOrder.Click += new System.Windows.RoutedEventHandler(this.finish_Clicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

