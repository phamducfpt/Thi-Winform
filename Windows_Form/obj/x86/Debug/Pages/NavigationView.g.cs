﻿#pragma checksum "C:\Users\Admin\source\repos\Windows_Form\Windows_Form\Pages\NavigationView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9C2CAB1D4ADE752623330BC5C9BC64F86F40BBAA89D52EFF2CEAAFD1EDD501E8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Windows_Form.Pages
{
    partial class NavigationView : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Pages\NavigationView.xaml line 11
                {
                    global::Windows.UI.Xaml.Controls.NavigationView element2 = (global::Windows.UI.Xaml.Controls.NavigationView)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationView)element2).SelectionChanged += this.NavigationView_SelectionChanged;
                }
                break;
            case 3: // Pages\NavigationView.xaml line 14
                {
                    this.add = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 4: // Pages\NavigationView.xaml line 15
                {
                    this.search = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 5: // Pages\NavigationView.xaml line 17
                {
                    this.contentFrame1 = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
