﻿#pragma checksum "..\..\..\OtherForms\Matrix3_2.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "547CDC2EC014A27EE3AB042721E998105904AB69C9BCA3FBE2A605EA26BD97A6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Science_Solver;
using Science_Solver.Utilities;
using Science_Solver.View;
using Science_Solver.ViewModel;
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


namespace Science_Solver.OtherForms {
    
    
    /// <summary>
    /// Matrix3_2
    /// </summary>
    public partial class Matrix3_2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 74 "..\..\..\OtherForms\Matrix3_2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox value0_0;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\OtherForms\Matrix3_2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox value0_1;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\OtherForms\Matrix3_2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox value1_0;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\OtherForms\Matrix3_2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox value1_1;
        
        #line default
        #line hidden
        
        
        #line 195 "..\..\..\OtherForms\Matrix3_2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox value2_0;
        
        #line default
        #line hidden
        
        
        #line 218 "..\..\..\OtherForms\Matrix3_2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox value2_1;
        
        #line default
        #line hidden
        
        
        #line 249 "..\..\..\OtherForms\Matrix3_2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseApp;
        
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
            System.Uri resourceLocater = new System.Uri("/Science Solver;component/otherforms/matrix3_2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\OtherForms\Matrix3_2.xaml"
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
            this.value0_0 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.value0_1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.value1_0 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.value1_1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.value2_0 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.value2_1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 238 "..\..\..\OtherForms\Matrix3_2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CloseApp = ((System.Windows.Controls.Button)(target));
            
            #line 250 "..\..\..\OtherForms\Matrix3_2.xaml"
            this.CloseApp.Click += new System.Windows.RoutedEventHandler(this.CloseApp_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

