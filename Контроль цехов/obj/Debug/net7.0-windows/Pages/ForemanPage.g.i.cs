﻿#pragma checksum "..\..\..\..\Pages\ForemanPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BEEB08A9D4C189804235A9716504F409769F7868"
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
    /// ForemanPage
    /// </summary>
    public partial class ForemanPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\Pages\ForemanPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl TabControlMain;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Pages\ForemanPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid EmployeesDataGrid;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Pages\ForemanPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox EmployeesListBox;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Pages\ForemanPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Pages\ForemanPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SearchTextBlock;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Pages\ForemanPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SendRequestButton;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\Pages\ForemanPage.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Контроль цехов;component/pages/foremanpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\ForemanPage.xaml"
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
            
            #line 9 "..\..\..\..\Pages\ForemanPage.xaml"
            ((УППО_Пропуски.Pages.ForemanPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TabControlMain = ((System.Windows.Controls.TabControl)(target));
            return;
            case 3:
            this.EmployeesDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.EmployeesListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.SearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 59 "..\..\..\..\Pages\ForemanPage.xaml"
            this.SearchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 59 "..\..\..\..\Pages\ForemanPage.xaml"
            this.SearchTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.SearchTextBlock_GotFocus);
            
            #line default
            #line hidden
            
            #line 59 "..\..\..\..\Pages\ForemanPage.xaml"
            this.SearchTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.SearchTextBlock_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SearchTextBlock = ((System.Windows.Controls.TextBlock)(target));
            
            #line 60 "..\..\..\..\Pages\ForemanPage.xaml"
            this.SearchTextBlock.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.SearchTextBlock_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SendRequestButton = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\..\Pages\ForemanPage.xaml"
            this.SendRequestButton.Click += new System.Windows.RoutedEventHandler(this.SendRequestButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.QuitButton = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\Pages\ForemanPage.xaml"
            this.QuitButton.Click += new System.Windows.RoutedEventHandler(this.QuitButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

