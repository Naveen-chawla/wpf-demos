﻿#pragma checksum "..\..\..\..\CommonView\DiagramFrontPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55CC0C88C68B288E24AB56789EBF731967FADA9E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DiagramFrontPageUtility;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace DiagramFrontPageUtility {
    
    
    /// <summary>
    /// DiagramFrontPage
    /// </summary>
    public partial class DiagramFrontPage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 153 "..\..\..\..\CommonView\DiagramFrontPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid NewFile;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\..\CommonView\DiagramFrontPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid PropertyEditor;
        
        #line default
        #line hidden
        
        
        #line 299 "..\..\..\..\CommonView\DiagramFrontPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox LayoutTypeSelection;
        
        #line default
        #line hidden
        
        
        #line 305 "..\..\..\..\CommonView\DiagramFrontPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid root;
        
        #line default
        #line hidden
        
        
        #line 310 "..\..\..\..\CommonView\DiagramFrontPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fileName;
        
        #line default
        #line hidden
        
        
        #line 350 "..\..\..\..\CommonView\DiagramFrontPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid root1;
        
        #line default
        #line hidden
        
        
        #line 411 "..\..\..\..\CommonView\DiagramFrontPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fileNam;
        
        #line default
        #line hidden
        
        
        #line 429 "..\..\..\..\CommonView\DiagramFrontPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textv;
        
        #line default
        #line hidden
        
        
        #line 444 "..\..\..\..\CommonView\DiagramFrontPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView fileList;
        
        #line default
        #line hidden
        
        
        #line 520 "..\..\..\..\CommonView\DiagramFrontPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl Dialog;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DiagramFrontPageUtility;component/commonview/diagramfrontpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\CommonView\DiagramFrontPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.NewFile = ((System.Windows.Controls.Grid)(target));
            
            #line 155 "..\..\..\..\CommonView\DiagramFrontPage.xaml"
            this.NewFile.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Pop_NewFileCreator);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PropertyEditor = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            
            #line 274 "..\..\..\..\CommonView\DiagramFrontPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseNewFilePopup_Clicked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LayoutTypeSelection = ((System.Windows.Controls.ComboBox)(target));
            
            #line 299 "..\..\..\..\CommonView\DiagramFrontPage.xaml"
            this.LayoutTypeSelection.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.root = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.fileName = ((System.Windows.Controls.TextBox)(target));
            
            #line 314 "..\..\..\..\CommonView\DiagramFrontPage.xaml"
            this.fileName.Loaded += new System.Windows.RoutedEventHandler(this.fileName_Loaded);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 318 "..\..\..\..\CommonView\DiagramFrontPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NewFileCreate_Clicked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.root1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            
            #line 356 "..\..\..\..\CommonView\DiagramFrontPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 384 "..\..\..\..\CommonView\DiagramFrontPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NewFileCreate_Clicked);
            
            #line default
            #line hidden
            return;
            case 11:
            this.fileNam = ((System.Windows.Controls.TextBox)(target));
            
            #line 417 "..\..\..\..\CommonView\DiagramFrontPage.xaml"
            this.fileNam.Loaded += new System.Windows.RoutedEventHandler(this.textBox_Loaded);
            
            #line default
            #line hidden
            return;
            case 12:
            this.textv = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.fileList = ((System.Windows.Controls.ListView)(target));
            
            #line 444 "..\..\..\..\CommonView\DiagramFrontPage.xaml"
            this.fileList.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.fileList_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 14:
            this.Dialog = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

