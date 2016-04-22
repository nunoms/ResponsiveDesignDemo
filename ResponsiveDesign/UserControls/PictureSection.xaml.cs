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
    public sealed partial class PictureSection : UserControl
    {
        public PictureSection()
        {
            this.InitializeComponent();
        }



        public List<Picture> PictureList
        {
            get { return (List<Picture>)GetValue(PictureListProperty); }
            set { SetValue(PictureListProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PictureList.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PictureListProperty =
            DependencyProperty.Register("PictureList", typeof(List<Picture>), typeof(PictureSection), new PropertyMetadata(null));



        public string SectionTitle
        {
            get { return (string)GetValue(SectionTitleProperty); }
            set { SetValue(SectionTitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SectionTitle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SectionTitleProperty =
            DependencyProperty.Register("SectionTitle", typeof(string), typeof(PictureSection), new PropertyMetadata(""));


    }
}
