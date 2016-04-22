using ResponsiveDesign.Models;
using System;
using System.Collections.Generic;
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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace ResponsiveDesign.UserControls
{
    public sealed partial class SplitViewNavigationList : UserControl
    {
        public SplitViewNavigationList()
        {
            this.InitializeComponent();
            this.Loaded += SplitViewNavigationList_Loaded;
        }

        private void SplitViewNavigationList_Loaded(object sender, RoutedEventArgs e)
        {
            if (navigationList.Items != null && navigationList.Items.Count > 0)
                navigationList.SelectedIndex = 0;
        }

        private void bottomNavigationList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            navigationList.SelectedIndex = -1;
            bottomNavigationList.SelectedIndex = -1;
        }

        public event EventHandler<SplitViewNavigationEventArgs> NavigationItemClicked;

      
        private void OnNavRequested(SplitViewNavigationItem item)
        {
            var handler = NavigationItemClicked;
            if (handler != null)
            {
                handler(this, new SplitViewNavigationEventArgs { NavItem = item.Label });
            }
        }

        private void navItem_Changed(object sender, SelectionChangedEventArgs e)
        {
            OnNavRequested(e.AddedItems[0] as SplitViewNavigationItem);
        }
    }

    public class SplitViewNavigationEventArgs : EventArgs
    {
        public string NavItem { get; set; }
    }
}
