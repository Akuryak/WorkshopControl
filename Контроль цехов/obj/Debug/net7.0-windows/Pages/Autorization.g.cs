﻿#pragma checksum "..\..\..\..\Pages\Autorization.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8D1DD3989D988F885117A62815BB2FB1E1DAA891"
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
using УППО_Пропуски.Pages;


namespace УППО_Пропуски.Pages {
    
    
    /// <summary>
    /// Autorization
    /// </summary>
    public partial class Autorization : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\Pages\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmployeeCodeTextBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Pages\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock EmployeeCodeTextBlock;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Pages\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox EmployeePasswordPasswordBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Pages\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock EmployeePasswordTextBlock;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Pages\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Контроль цехов;component/pages/autorization.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Autorization.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.EmployeeCodeTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\..\Pages\Autorization.xaml"
            this.EmployeeCodeTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.EmployeeCodeTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 35 "..\..\..\..\Pages\Autorization.xaml"
            this.EmployeeCodeTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.EmployeeCodeTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.EmployeeCodeTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.EmployeePasswordPasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 38 "..\..\..\..\Pages\Autorization.xaml"
            this.EmployeePasswordPasswordBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.EmployeePasswordPasswordBox_KeyDown);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\..\Pages\Autorization.xaml"
            this.EmployeePasswordPasswordBox.GotFocus += new System.Windows.RoutedEventHandler(this.EmployeePasswordPasswordBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\..\Pages\Autorization.xaml"
            this.EmployeePasswordPasswordBox.LostFocus += new System.Windows.RoutedEventHandler(this.EmployeePasswordPasswordBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EmployeePasswordTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.LoginButton = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\Pages\Autorization.xaml"
            this.LoginButton.Click += new System.Windows.RoutedEventHandler(this.LoginButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

