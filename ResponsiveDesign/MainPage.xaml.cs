using ResponsiveDesign.HelperViews;
using ResponsiveDesign.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ResponsiveDesign
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            App.NavFrame = navFrame;
            navFrame.Navigate(typeof(MainMenu));
            navFrame.Navigating += NavFrame_Navigating;
          
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().TryResizeView(new Size(955, 828));
         
            SystemNavigationManager.GetForCurrentView().BackRequested += MainPage_BackRequested;
         
             if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.Phone.UI.Input.HardwareButtons"))
            {
                backButton.Visibility = Visibility.Collapsed;
                resizeButton.Visibility = Visibility.Collapsed;
             }
        }

        private void MainPage_BackRequested(object sender, BackRequestedEventArgs e)
        {
            if (navFrame.CanGoBack)
            {
                navFrame.GoBack();
                e.Handled = true;
            }
        }

        private void NavFrame_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            var nav = e.Parameter as NavigationItem;
            if (nav == null)
            {
                title.Text = "Responsive Design";
                return;
            }
            title.Text = nav.Label;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            if (App.NavFrame.CanGoBack)
                App.NavFrame.GoBack();
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(320, 540));
        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(500, 800));
        }
    }
}
