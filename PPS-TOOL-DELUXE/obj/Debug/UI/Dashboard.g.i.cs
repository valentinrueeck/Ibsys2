﻿#pragma checksum "..\..\..\UI\Dashboard.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81E08B77B79B93E37D9036DFEA7ED85BB4A9E0D3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using PPS_TOOL_DELUXE.Properties;
using PPS_TOOL_DELUXE.ViewModel;
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


namespace PPS_TOOL_DELUXE.UI {
    
    
    /// <summary>
    /// Dashboard
    /// </summary>
    public partial class Dashboard : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\UI\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabPage;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\UI\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnImport;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\UI\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnPlan;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\UI\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabMasterAdmin;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\UI\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnWorkplaces;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\UI\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnProduces;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\UI\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnPurchases;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\UI\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnGerman;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\UI\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEnglish;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\UI\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridPeriods;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\UI\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnFrench;
        
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
            System.Uri resourceLocater = new System.Uri("/PPS-TOOL-DELUXE;component/ui/dashboard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\Dashboard.xaml"
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
            this.LabPage = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.BtnImport = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\UI\Dashboard.xaml"
            this.BtnImport.Click += new System.Windows.RoutedEventHandler(this.btn_Periode_importieren_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnPlan = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\UI\Dashboard.xaml"
            this.BtnPlan.Click += new System.Windows.RoutedEventHandler(this.btn_Periode_planen_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LabMasterAdmin = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.BtnWorkplaces = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\UI\Dashboard.xaml"
            this.BtnWorkplaces.Click += new System.Windows.RoutedEventHandler(this.btn_Arbeitsplätze_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnProduces = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\UI\Dashboard.xaml"
            this.BtnProduces.Click += new System.Windows.RoutedEventHandler(this.btn_Erzeugnisse_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnPurchases = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\UI\Dashboard.xaml"
            this.BtnPurchases.Click += new System.Windows.RoutedEventHandler(this.btn_Kaufteile_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnGerman = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\UI\Dashboard.xaml"
            this.BtnGerman.Click += new System.Windows.RoutedEventHandler(this.BtnGerman_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnEnglish = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\UI\Dashboard.xaml"
            this.BtnEnglish.Click += new System.Windows.RoutedEventHandler(this.BtnEnglish_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.GridPeriods = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 11:
            this.BtnFrench = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\UI\Dashboard.xaml"
            this.BtnFrench.Click += new System.Windows.RoutedEventHandler(this.BtnFrench_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

