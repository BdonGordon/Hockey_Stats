﻿#pragma checksum "..\..\StarterControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "81A9C4A6594477A11C7123E4A9F84841"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Hockey_Stats;
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


namespace Hockey_Stats {
    
    
    /// <summary>
    /// StarterControl
    /// </summary>
    public partial class StarterControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\StarterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label team_name_Start;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\StarterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label position_Notifier;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\StarterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid players_Section;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\StarterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button player_1;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\StarterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button player_2;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\StarterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button player_3;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\StarterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button player_4;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\StarterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button player_5;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\StarterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button start_Button;
        
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
            System.Uri resourceLocater = new System.Uri("/Hockey_Stats;component/startercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StarterControl.xaml"
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
            this.team_name_Start = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.position_Notifier = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.players_Section = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.player_1 = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\StarterControl.xaml"
            this.player_1.Click += new System.Windows.RoutedEventHandler(this.player_1_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.player_2 = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\StarterControl.xaml"
            this.player_2.Click += new System.Windows.RoutedEventHandler(this.player_2_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.player_3 = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\StarterControl.xaml"
            this.player_3.Click += new System.Windows.RoutedEventHandler(this.player_3_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.player_4 = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\StarterControl.xaml"
            this.player_4.Click += new System.Windows.RoutedEventHandler(this.player_4_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.player_5 = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\StarterControl.xaml"
            this.player_5.Click += new System.Windows.RoutedEventHandler(this.player_5_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.start_Button = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\StarterControl.xaml"
            this.start_Button.Click += new System.Windows.RoutedEventHandler(this.start_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
