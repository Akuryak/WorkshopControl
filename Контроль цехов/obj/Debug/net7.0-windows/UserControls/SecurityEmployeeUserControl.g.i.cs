﻿#pragma checksum "..\..\..\..\UserControls\SecurityEmployeeUserControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E8969C3751D666B62BE4491E87F4B7D78CB63EE8"
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
using УППО_Пропуски.UserControls;


namespace УППО_Пропуски.UserControls {
    
    
    /// <summary>
    /// SecurityEmployeeUserControl
    /// </summary>
    public partial class SecurityEmployeeUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\UserControls\SecurityEmployeeUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image UserPhotoImage;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\UserControls\SecurityEmployeeUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock FullNameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\UserControls\SecurityEmployeeUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock GenderTextBlock;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\UserControls\SecurityEmployeeUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock BirthdateTextBlock;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\UserControls\SecurityEmployeeUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PasswordTextBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\UserControls\SecurityEmployeeUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StatusTextBox;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\UserControls\SecurityEmployeeUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DivisionComboBox;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\UserControls\SecurityEmployeeUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CanVisitOtherWorkshops;
        
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
            System.Uri resourceLocater = new System.Uri("/Контроль цехов;component/usercontrols/securityemployeeusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControls\SecurityEmployeeUserControl.xaml"
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
            this.UserPhotoImage = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.FullNameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.GenderTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.BirthdateTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.PasswordTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 43 "..\..\..\..\UserControls\SecurityEmployeeUserControl.xaml"
            this.PasswordTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.PasswordTextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 43 "..\..\..\..\UserControls\SecurityEmployeeUserControl.xaml"
            this.PasswordTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.PasswordTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.StatusTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\..\..\UserControls\SecurityEmployeeUserControl.xaml"
            this.StatusTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.StatusTextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 46 "..\..\..\..\UserControls\SecurityEmployeeUserControl.xaml"
            this.StatusTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.StatusTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DivisionComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 55 "..\..\..\..\UserControls\SecurityEmployeeUserControl.xaml"
            this.DivisionComboBox.LostFocus += new System.Windows.RoutedEventHandler(this.DivisionComboBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CanVisitOtherWorkshops = ((System.Windows.Controls.CheckBox)(target));
            
            #line 70 "..\..\..\..\UserControls\SecurityEmployeeUserControl.xaml"
            this.CanVisitOtherWorkshops.Click += new System.Windows.RoutedEventHandler(this.CanVisitOtherWorkshops_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

