﻿#pragma checksum "..\..\..\Vistas\AgregarLibro.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6D3E0F865484CEBFD362342FAC6F9E39B8452DB0982CF01213E3531F1A28DF7E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Libreria_GUI.Vistas;
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


namespace Libreria_GUI.Vistas {
    
    
    /// <summary>
    /// AgregarLibro
    /// </summary>
    public partial class AgregarLibro : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Vistas\AgregarLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblIsbn;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Vistas\AgregarLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTitulo;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Vistas\AgregarLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblAutorLibro;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Vistas\AgregarLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDisponibilidad;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Vistas\AgregarLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIsbn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Vistas\AgregarLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTituloLibro;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Vistas\AgregarLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAutorLibro;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Vistas\AgregarLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkDisponible;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Vistas\AgregarLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAgregarLibro;
        
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
            System.Uri resourceLocater = new System.Uri("/Libreria_GUI;component/vistas/agregarlibro.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Vistas\AgregarLibro.xaml"
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
            this.lblIsbn = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.lblTitulo = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblAutorLibro = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblDisponibilidad = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtIsbn = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\..\Vistas\AgregarLibro.xaml"
            this.txtIsbn.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtTituloLibro = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtAutorLibro = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.chkDisponible = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 9:
            this.btnAgregarLibro = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Vistas\AgregarLibro.xaml"
            this.btnAgregarLibro.Click += new System.Windows.RoutedEventHandler(this.btnAgregarLibro_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

