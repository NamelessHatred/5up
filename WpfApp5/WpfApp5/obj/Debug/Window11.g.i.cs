﻿#pragma checksum "..\..\Window11.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "830460B10FDB7F7C058B08535489709629253B220D090F69C8C0663F896EA6B4"
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
    /// Window11
    /// </summary>
    public partial class Window11 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\Window11.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Pla;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Window11.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button oleg;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Window11.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LivePointLocation;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Window11.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FoodAtLeast;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Window11.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HowMuchComfortable;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp5;component/window11.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window11.xaml"
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
            
            #line 24 "..\..\Window11.xaml"
            this.Pla.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.Pla_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.oleg = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\Window11.xaml"
            this.oleg.Click += new System.Windows.RoutedEventHandler(this.oleg_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 27 "..\..\Window11.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.add_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 28 "..\..\Window11.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ch_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 29 "..\..\Window11.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.del_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LivePointLocation = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\Window11.xaml"
            this.LivePointLocation.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.name_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FoodAtLeast = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\Window11.xaml"
            this.FoodAtLeast.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.name_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 8:
            this.HowMuchComfortable = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\Window11.xaml"
            this.HowMuchComfortable.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.age_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

