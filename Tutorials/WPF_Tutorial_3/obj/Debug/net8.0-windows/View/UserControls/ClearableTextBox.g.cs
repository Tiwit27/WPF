﻿#pragma checksum "..\..\..\..\..\View\UserControls\ClearableTextBox.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "383B0800F3CEE7D2627D2819EBC2E09744948265"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using WPF_Tutorial_3.View.UserControls;


namespace WPF_Tutorial_3.View.UserControls {
    
    
    /// <summary>
    /// ClearableTextBox
    /// </summary>
    public partial class ClearableTextBox : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\..\View\UserControls\ClearableTextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtInput;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\View\UserControls\ClearableTextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbPlaceholder;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\View\UserControls\ClearableTextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonClear;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF_Tutorial_3;component/view/usercontrols/clearabletextbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\UserControls\ClearableTextBox.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\..\..\View\UserControls\ClearableTextBox.xaml"
            this.txtInput.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtInput_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbPlaceholder = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.buttonClear = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\..\View\UserControls\ClearableTextBox.xaml"
            this.buttonClear.Click += new System.Windows.RoutedEventHandler(this.buttonClear_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

