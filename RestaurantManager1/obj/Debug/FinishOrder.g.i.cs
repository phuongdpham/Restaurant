﻿#pragma checksum "..\..\FinishOrder.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F4AA92F1CBDB5784B885DCBF6BB86D6D"
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
    /// FinishOrder
    /// </summary>
    public partial class FinishOrder : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\FinishOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridResult;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\FinishOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox tbCB;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\FinishOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock totalTBl;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\FinishOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button getReusult;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\FinishOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clearOrders;
        
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
            System.Uri resourceLocater = new System.Uri("/RestaurantManager1;component/finishorder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FinishOrder.xaml"
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
            this.gridResult = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.tbCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.totalTBl = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.getReusult = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\FinishOrder.xaml"
            this.getReusult.Click += new System.Windows.RoutedEventHandler(this.getReusult_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.clearOrders = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\FinishOrder.xaml"
            this.clearOrders.Click += new System.Windows.RoutedEventHandler(this.clearOrders_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
