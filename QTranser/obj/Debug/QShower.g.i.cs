﻿#pragma checksum "..\..\QShower.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F6E18E6AC5351F1FB8615B351A1BDABCD3F7CF17579C0C9B8E3E94CD67D630CB"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using HotKeyEditor;
using QTranser;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace QTranser {
    
    
    /// <summary>
    /// QShower
    /// </summary>
    public partial class QShower : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 160 "..\..\QShower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StrIBox;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\QShower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox HistoryList;
        
        #line default
        #line hidden
        
        
        #line 272 "..\..\QShower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox HistoryListBox;
        
        #line default
        #line hidden
        
        
        #line 292 "..\..\QShower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HotKeyQ;
        
        #line default
        #line hidden
        
        
        #line 293 "..\..\QShower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HotKeyW;
        
        #line default
        #line hidden
        
        
        #line 294 "..\..\QShower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HotKeyB;
        
        #line default
        #line hidden
        
        
        #line 295 "..\..\QShower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HotKeyG;
        
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
            System.Uri resourceLocater = new System.Uri("/QTranser;component/qshower.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\QShower.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 12 "..\..\QShower.xaml"
            ((QTranser.QShower)(target)).Deactivated += new System.EventHandler(this.Window_Deactivated);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 144 "..\..\QShower.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SetTop_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.StrIBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 171 "..\..\QShower.xaml"
            this.StrIBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.StrIBox_KeyUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.HistoryList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.HistoryListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.HotKeyQ = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.HotKeyW = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.HotKeyB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.HotKeyG = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 136 "..\..\QShower.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.HistoryList_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 137 "..\..\QShower.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseRightButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.HistoryList_MouseRightButtonUp);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

