﻿#pragma checksum "..\..\..\UI\Subkomponente hinzufügen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D5DC29A4202376A553179858F99A80796A0884F5"
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


namespace PPS_TOOL_DELUXE.Utility {
    
    
    /// <summary>
    /// SubkomponenteHinzufügen
    /// </summary>
    public partial class SubkomponenteHinzufügen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\UI\Subkomponente hinzufügen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PPS_TOOL_DELUXE.Utility.SubkomponenteHinzufügen SubKomponenteHinzufuegenWindow;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\UI\Subkomponente hinzufügen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Drop_Down_Arbeitsplatz;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\UI\Subkomponente hinzufügen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_abbrechen;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\UI\Subkomponente hinzufügen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_hinzufügen;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\UI\Subkomponente hinzufügen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textbox_Rüstzeit;
        
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
            System.Uri resourceLocater = new System.Uri("/PPS-TOOL-DELUXE;component/ui/subkomponente%20hinzuf%c3%bcgen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\Subkomponente hinzufügen.xaml"
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
            this.SubKomponenteHinzufuegenWindow = ((PPS_TOOL_DELUXE.Utility.SubkomponenteHinzufügen)(target));
            return;
            case 2:
            this.Drop_Down_Arbeitsplatz = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.btn_abbrechen = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\UI\Subkomponente hinzufügen.xaml"
            this.btn_abbrechen.Click += new System.Windows.RoutedEventHandler(this.btn_abbrechen_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_hinzufügen = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\UI\Subkomponente hinzufügen.xaml"
            this.btn_hinzufügen.Click += new System.Windows.RoutedEventHandler(this.btn_hinzufügen_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Textbox_Rüstzeit = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

