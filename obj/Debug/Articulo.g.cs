﻿#pragma checksum "..\..\Articulo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "660C40C1EE15A19C697DEE9A9F2B68BB57B7D31A5BBA49388C4DD023734005E4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Inventario_y_Contabilidad;
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


namespace Inventario_y_Contabilidad {
    
    
    /// <summary>
    /// Articulo
    /// </summary>
    public partial class Articulo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Articulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescArt;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Articulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblIdArt;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Articulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCostoDolar;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Articulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrecioDolar;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\Articulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrecioBs;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\Articulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrecioBsEfect;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\Articulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCantidadAgg;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\Articulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAceptar;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\Articulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBuscar;
        
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
            System.Uri resourceLocater = new System.Uri("/Inventario y Contabilidad;component/articulo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Articulo.xaml"
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
            this.txtDescArt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.lblIdArt = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.txtCostoDolar = ((System.Windows.Controls.TextBox)(target));
            
            #line 48 "..\..\Articulo.xaml"
            this.txtCostoDolar.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtCostoDolar_KeyUp);
            
            #line default
            #line hidden
            
            #line 49 "..\..\Articulo.xaml"
            this.txtCostoDolar.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtCostoDolar_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtPrecioDolar = ((System.Windows.Controls.TextBox)(target));
            
            #line 66 "..\..\Articulo.xaml"
            this.txtPrecioDolar.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtPrecioDolar_KeyDown);
            
            #line default
            #line hidden
            
            #line 67 "..\..\Articulo.xaml"
            this.txtPrecioDolar.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtPrecioDolar_KeyUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtPrecioBs = ((System.Windows.Controls.TextBox)(target));
            
            #line 86 "..\..\Articulo.xaml"
            this.txtPrecioBs.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtPrecioBs_KeyDown);
            
            #line default
            #line hidden
            
            #line 87 "..\..\Articulo.xaml"
            this.txtPrecioBs.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtPrecioBs_KeyUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtPrecioBsEfect = ((System.Windows.Controls.TextBox)(target));
            
            #line 104 "..\..\Articulo.xaml"
            this.txtPrecioBsEfect.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtPrecioBsEfect_KeyUp);
            
            #line default
            #line hidden
            
            #line 105 "..\..\Articulo.xaml"
            this.txtPrecioBsEfect.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtPrecioBsEfect_KeyDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtCantidadAgg = ((System.Windows.Controls.TextBox)(target));
            
            #line 122 "..\..\Articulo.xaml"
            this.txtCantidadAgg.KeyDown += new System.Windows.Input.KeyEventHandler(this.soloNum);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnAceptar = ((System.Windows.Controls.Button)(target));
            
            #line 132 "..\..\Articulo.xaml"
            this.btnAceptar.Click += new System.Windows.RoutedEventHandler(this.btnAceptar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnBuscar = ((System.Windows.Controls.Button)(target));
            
            #line 141 "..\..\Articulo.xaml"
            this.btnBuscar.Click += new System.Windows.RoutedEventHandler(this.btnBuscar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

