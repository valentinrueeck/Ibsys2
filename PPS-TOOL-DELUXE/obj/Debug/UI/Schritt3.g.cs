﻿#pragma checksum "..\..\..\UI\Schritt3.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7BCB25F74C22BBB1840A54184316D5703B881C5B"
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
using PPS_TOOL_DELUXE.Properties;
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
    /// Step3
    /// </summary>
    public partial class Step3 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\UI\Schritt3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PPS_TOOL_DELUXE.UI.Step3 Schritt3;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\UI\Schritt3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Schritt3_abbrechen;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\UI\Schritt3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Schritt3_weiter;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\UI\Schritt3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid producesGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/PPS-TOOL-DELUXE;component/ui/schritt3.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\Schritt3.xaml"
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
            this.Schritt3 = ((PPS_TOOL_DELUXE.UI.Step3)(target));
            
            #line 11 "..\..\..\UI\Schritt3.xaml"
            this.Schritt3.ContentRendered += new System.EventHandler(this.Schritt3_ContentRendered);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Schritt3_abbrechen = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\UI\Schritt3.xaml"
            this.Schritt3_abbrechen.Click += new System.Windows.RoutedEventHandler(this.Schritt3_abbrechen_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Schritt3_weiter = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.producesGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

