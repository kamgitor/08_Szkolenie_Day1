﻿#pragma checksum "..\..\PersonEdit.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "072E0306B2984D9B2680A0FABA6932FF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3655
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace Day1 {
    
    
    /// <summary>
    /// PersonEdit
    /// </summary>
    public partial class PersonEdit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\PersonEdit.xaml"
        internal System.Windows.Controls.Button Key_OK;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\PersonEdit.xaml"
        internal System.Windows.Controls.Button Key_Esc;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\PersonEdit.xaml"
        internal System.Windows.Controls.TextBox Box_imie;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\PersonEdit.xaml"
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\PersonEdit.xaml"
        internal System.Windows.Controls.TextBox Box_name;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\PersonEdit.xaml"
        internal System.Windows.Controls.Label label2;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\PersonEdit.xaml"
        internal System.Windows.Controls.TextBox Box_klasa;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\PersonEdit.xaml"
        internal System.Windows.Controls.Label label3;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Day1;component/personedit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PersonEdit.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Key_OK = ((System.Windows.Controls.Button)(target));
            
            #line 6 "..\..\PersonEdit.xaml"
            this.Key_OK.Click += new System.Windows.RoutedEventHandler(this.Key_OK_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Key_Esc = ((System.Windows.Controls.Button)(target));
            
            #line 7 "..\..\PersonEdit.xaml"
            this.Key_Esc.Click += new System.Windows.RoutedEventHandler(this.Key_Esc_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Box_imie = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.Box_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.label2 = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.Box_klasa = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.label3 = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
