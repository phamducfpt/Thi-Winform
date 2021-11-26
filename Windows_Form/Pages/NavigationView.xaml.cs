using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Windows_Form.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NavigationView : Page
    {
        public NavigationView()
        {
            this.InitializeComponent();
            
        }

        private void NavigationView_SelectionChanged(Windows.UI.Xaml.Controls.NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (sender is null)
            {
                throw new ArgumentNullException(nameof(sender));
            }

            if (args.IsSettingsSelected)
            {
                //click nut' setting
                Debug.WriteLine("select setting");
            }
            var navigationViewItem = args.SelectedItem as NavigationViewItem;
            switch (navigationViewItem.Name)
            {
                case "add":
                    this.contentFrame1.Navigate(typeof(Pages.AddContact));
                    break;
                case "search":
                    this.contentFrame1.Navigate(typeof(Pages.SearchContact));
                    break;
                case "listContact":
                    this.contentFrame1.Navigate(typeof(Pages.ListView));
                    break;
            }
        }
    }
}
