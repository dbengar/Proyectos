﻿#pragma checksum "..\..\partido.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FDE165F47A8B659AB78F0A7A520F0F13440D0D49883A89833B0037DE67832637"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using DI_UT2_PRACT1_Campeonato;
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


namespace DI_UT2_PRACT1_Campeonato {
    
    
    /// <summary>
    /// partido
    /// </summary>
    public partial class partido : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\partido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblFechaPartido;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\partido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblEquipo1;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\partido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblEquipo2;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\partido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtBoxEquipo1;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\partido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtBoxEquipo2;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\partido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnResultado;
        
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
            System.Uri resourceLocater = new System.Uri("/DI_UT2_PRACT1-Campeonato;component/partido.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\partido.xaml"
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
            this.LblFechaPartido = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.LblEquipo1 = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.LblEquipo2 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.TxtBoxEquipo1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TxtBoxEquipo2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.BtnResultado = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\partido.xaml"
            this.BtnResultado.Click += new System.Windows.RoutedEventHandler(this.BtnResultado_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
