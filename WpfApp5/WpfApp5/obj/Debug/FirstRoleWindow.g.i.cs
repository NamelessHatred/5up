﻿#pragma checksum "..\..\FirstRoleWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7153F702F779A4D84E6EF97F2674BDA57F97F3D991147DD41BDA1689B4F575AE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfApp5;


namespace WpfApp5 {
    
    
    /// <summary>
    /// FirstRoleWindow
    /// </summary>
    public partial class FirstRoleWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\FirstRoleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Pla;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\FirstRoleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button oleg;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\FirstRoleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ClientName;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\FirstRoleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ClientSureName;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\FirstRoleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ClientFather;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\FirstRoleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ClientMail;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\FirstRoleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BuyNumber;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp5;component/firstrolewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FirstRoleWindow.xaml"
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
            this.Pla = ((System.Windows.Controls.DataGrid)(target));
            
            #line 23 "..\..\FirstRoleWindow.xaml"
            this.Pla.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.Pla_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.oleg = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\FirstRoleWindow.xaml"
            this.oleg.Click += new System.Windows.RoutedEventHandler(this.oleg_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 28 "..\..\FirstRoleWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.add_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 29 "..\..\FirstRoleWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ch_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 30 "..\..\FirstRoleWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.del_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ClientName = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\FirstRoleWindow.xaml"
            this.ClientName.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.name_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ClientSureName = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\FirstRoleWindow.xaml"
            this.ClientSureName.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.name_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ClientFather = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\FirstRoleWindow.xaml"
            this.ClientFather.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.name_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ClientMail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.BuyNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\FirstRoleWindow.xaml"
            this.BuyNumber.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.age_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

