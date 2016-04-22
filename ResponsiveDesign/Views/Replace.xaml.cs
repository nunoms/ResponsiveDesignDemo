using ResponsiveDesign.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ResponsiveDesign.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Replace : Page
    {


        public PicturesViewModel PicturesViewModel
        {
            get { return (PicturesViewModel)GetValue(PicturesViewModelProperty); }
            set { SetValue(PicturesViewModelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PicturesViewModel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PicturesViewModelProperty =
            DependencyProperty.Register("PicturesViewModel", typeof(PicturesViewModel), typeof(Replace), new PropertyMetadata(null));




        public Channel9ViewModel Channel9ViewModel
        {
            get { return (Channel9ViewModel)GetValue(Channel9ViewModelProperty); }
            set { SetValue(Channel9ViewModelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Channel9ViewModel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Channel9ViewModelProperty =
            DependencyProperty.Register("Channel9ViewModel", typeof(Channel9ViewModel), typeof(Replace), new PropertyMetadata(null));



        public Replace()
        {
            this.InitializeComponent();
            Channel9ViewModel = new Channel9ViewModel();
            PicturesViewModel = new PicturesViewModel();
        }

        private void testButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
