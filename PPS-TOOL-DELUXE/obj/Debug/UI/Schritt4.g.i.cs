﻿#pragma checksum "..\..\..\UI\Schritt4.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9B697691A7CCA2BF329028F04640F37E0ED8D1E3"
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
    /// Step4
    /// </summary>
    public partial class Step4 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\UI\Schritt4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PPS_TOOL_DELUXE.UI.Step4 Schritt4;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\UI\Schritt4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid layoutRoot;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\UI\Schritt4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Schritt4_abbrechen;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\UI\Schritt4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Schritt4_weiter;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\UI\Schritt4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid producesGrid;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\UI\Schritt4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup popup1;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\UI\Schritt4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_plus;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\UI\Schritt4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_minus;
        
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
            System.Uri resourceLocater = new System.Uri("/PPS-TOOL-DELUXE;component/ui/schritt4.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\Schritt4.xaml"
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
            this.Schritt4 = ((PPS_TOOL_DELUXE.UI.Step4)(target));
            
            #line 10 "..\..\..\UI\Schritt4.xaml"
            this.Schritt4.ContentRendered += new System.EventHandler(this.Schritt4_ContentRendered);
            
            #line default
            #line hidden
            return;
            case 2:
            this.layoutRoot = ((System.Windows.Controls.Grid)(target));
            
            #line 55 "..\..\..\UI\Schritt4.xaml"
            this.layoutRoot.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.OnMouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 56 "..\..\..\UI\Schritt4.xaml"
            this.layoutRoot.MouseMove += new System.Windows.Input.MouseEventHandler(this.OnMouseMove);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Schritt4_abbrechen = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\UI\Schritt4.xaml"
            this.Schritt4_abbrechen.Click += new System.Windows.RoutedEventHandler(this.Schritt4_abbrechen_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Schritt4_weiter = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.producesGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 69 "..\..\..\UI\Schritt4.xaml"
            this.producesGrid.BeginningEdit += new System.EventHandler<System.Windows.Controls.DataGridBeginningEditEventArgs>(this.OnBeginEdit);
            
            #line default
            #line hidden
            
            #line 70 "..\..\..\UI\Schritt4.xaml"
            this.producesGrid.CellEditEnding += new System.EventHandler<System.Windows.Controls.DataGridCellEditEndingEventArgs>(this.OnEndEdit);
            
            #line default
            #line hidden
            
            #line 71 "..\..\..\UI\Schritt4.xaml"
            this.producesGrid.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.OnMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 71 "..\..\..\UI\Schritt4.xaml"
            this.producesGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.producesGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.popup1 = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 7:
            this.btn_plus = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.btn_minus = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

