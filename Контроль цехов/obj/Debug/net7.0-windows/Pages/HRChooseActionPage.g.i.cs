﻿#pragma checksum "..\..\..\..\Pages\HRChooseActionPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D02A27B75F8F690A3F8F6E8F830A46385E2FC154"
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
    /// HRChooseActionPage
    /// </summary>
    public partial class HRChooseActionPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\Pages\HRChooseActionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MakeRequestButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Pages\HRChooseActionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNewEmployeeButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Pages\HRChooseActionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button QuitButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Контроль цехов;component/pages/hrchooseactionpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\HRChooseActionPage.xaml"
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
            this.MakeRequestButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\Pages\HRChooseActionPage.xaml"
            this.MakeRequestButton.Click += new System.Windows.RoutedEventHandler(this.MakeRequestButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddNewEmployeeButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\Pages\HRChooseActionPage.xaml"
            this.AddNewEmployeeButton.Click += new System.Windows.RoutedEventHandler(this.AddNewEmployeeButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.QuitButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\Pages\HRChooseActionPage.xaml"
            this.QuitButton.Click += new System.Windows.RoutedEventHandler(this.QuitButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

