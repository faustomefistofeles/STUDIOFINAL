﻿#pragma checksum "..\..\..\View\frmAlunoAgenda.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DA6F3E3CA8BC408DCDEDF7DA24859E71"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using StudioPilates.View;
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


namespace StudioPilates.View {
    
    
    /// <summary>
    /// frmAlunoAgenda
    /// </summary>
    public partial class frmAlunoAgenda : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\View\frmAlunoAgenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbAula;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\View\frmAlunoAgenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbAluno;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\View\frmAlunoAgenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblAula;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\View\frmAlunoAgenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblAluno;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\View\frmAlunoAgenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGravar;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\View\frmAlunoAgenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/StudioPilates;component/view/frmalunoagenda.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\frmAlunoAgenda.xaml"
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
            this.cmbAula = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\..\View\frmAlunoAgenda.xaml"
            this.cmbAula.Loaded += new System.Windows.RoutedEventHandler(this.cmbAula_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmbAluno = ((System.Windows.Controls.ComboBox)(target));
            
            #line 13 "..\..\..\View\frmAlunoAgenda.xaml"
            this.cmbAluno.Loaded += new System.Windows.RoutedEventHandler(this.cmbAluno_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lblAula = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblAluno = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.btnGravar = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\View\frmAlunoAgenda.xaml"
            this.btnGravar.Click += new System.Windows.RoutedEventHandler(this.btnGravar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 17 "..\..\..\View\frmAlunoAgenda.xaml"
            this.dataGrid.Loaded += new System.Windows.RoutedEventHandler(this.dataGrid_Loaded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
