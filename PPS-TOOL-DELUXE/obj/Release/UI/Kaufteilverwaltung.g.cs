﻿#pragma checksum "..\..\..\UI\Kaufteilverwaltung.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34392DB4B7DE298E27C6EA9C37DE916362BB7511"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using PPS_TOOL_DELUXE;
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
    /// Kaufteilverwaltung
    /// </summary>
    public partial class Kaufteilverwaltung : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\UI\Kaufteilverwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PPS_TOOL_DELUXE.UI.Kaufteilverwaltung KaufteileverwaltungWindow;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\UI\Kaufteilverwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Arbeitsplatzverwaltung_zurück;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\UI\Kaufteilverwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Kaufteilverwaltung_bearbeiten;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\UI\Kaufteilverwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid purchasesGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/PPS-TOOL-DELUXE;component/ui/kaufteilverwaltung.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\Kaufteilverwaltung.xaml"
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
            this.KaufteileverwaltungWindow = ((PPS_TOOL_DELUXE.UI.Kaufteilverwaltung)(target));
            return;
            case 2:
            this.btn_Arbeitsplatzverwaltung_zurück = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.btn_Kaufteilverwaltung_bearbeiten = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\UI\Kaufteilverwaltung.xaml"
            this.btn_Kaufteilverwaltung_bearbeiten.Click += new System.Windows.RoutedEventHandler(this.btn_Kaufteilverwaltung_bearbeiten_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.purchasesGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 27 "..\..\..\UI\Kaufteilverwaltung.xaml"
            this.purchasesGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.purchasesGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

