﻿#pragma checksum "..\..\..\..\Pages\admin\AdminFramePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "37AAE4DB472CE0517E26506C6EB85435A8B1D372F5B61746DBB3503F1238F5AD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using WpfApp.Pages.admin;


namespace WpfApp.Pages.admin {
    
    
    /// <summary>
    /// AdminFramePage
    /// </summary>
    public partial class AdminFramePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\Pages\admin\AdminFramePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonUsersPage;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Pages\admin\AdminFramePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonVehiclesPage;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Pages\admin\AdminFramePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonBookingsPage;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Pages\admin\AdminFramePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonReviewsPage;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Pages\admin\AdminFramePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonPaymentsPage;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Pages\admin\AdminFramePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frameAdmin;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp;component/pages/admin/adminframepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\admin\AdminFramePage.xaml"
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
            this.ButtonUsersPage = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\Pages\admin\AdminFramePage.xaml"
            this.ButtonUsersPage.Click += new System.Windows.RoutedEventHandler(this.ButtonUsersPage_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonVehiclesPage = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\Pages\admin\AdminFramePage.xaml"
            this.ButtonVehiclesPage.Click += new System.Windows.RoutedEventHandler(this.ButtonVehiclesPage_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonBookingsPage = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\Pages\admin\AdminFramePage.xaml"
            this.ButtonBookingsPage.Click += new System.Windows.RoutedEventHandler(this.ButtonBookingsPage_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonReviewsPage = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\Pages\admin\AdminFramePage.xaml"
            this.ButtonReviewsPage.Click += new System.Windows.RoutedEventHandler(this.ButtonReviewsPage_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonPaymentsPage = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\Pages\admin\AdminFramePage.xaml"
            this.ButtonPaymentsPage.Click += new System.Windows.RoutedEventHandler(this.ButtonPaymentsPage_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.frameAdmin = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

