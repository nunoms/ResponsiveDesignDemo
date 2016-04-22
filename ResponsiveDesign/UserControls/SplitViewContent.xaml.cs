using ResponsiveDesign.ViewModels;
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
    public sealed partial class SplitViewContent : UserControl
    {

        public SplitViewNavigationViewModel SplitViewNavigationViewModel { get; set; }

        public SplitViewContent()
        {
            this.InitializeComponent();
            SplitViewNavigationViewModel = new SplitViewNavigationViewModel();

            //need to load something by default...the mobile view also has a contentcontrol with the same name
            PictureCatalog catalog = new PictureCatalog();
            myContent.Content = catalog;
        }

        private void navigationContainer_NavigationItemClicked(object sender, SplitViewNavigationEventArgs e)
        {
            pageTitle.Text = e.NavItem.ToUpper();
            switch (e.NavItem)
            {
                case "Home":
                    {
                        PictureCatalog catalog = new PictureCatalog();
                        catalog.DataContext = new PicturesViewModel();
                        myContent.Content = catalog;
                        break;
                    }
                case "Top Pictures":
                    {
                        TopPictures Pictures = new TopPictures();
                        myContent.Content = Pictures;
                        break;
                    }
                default:
                    {
                        Grid g = new Grid();
                        g.Padding = new Thickness(20);
                        g.VerticalAlignment = VerticalAlignment.Stretch;

                        TextBlock t = new TextBlock();
                        t.TextWrapping = TextWrapping.WrapWholeWords;
                        t.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam varius finibus nisi et laoreet. Nullam et semper ipsum. Donec suscipit sem sit amet ligula maximus condimentum. Integer velit risus, rutrum id elit a, posuere vulputate libero. Phasellus lectus metus, rutrum quis elementum et, blandit ac nulla. Nunc gravida vel nisl sit amet lacinia.Nullam at consectetur urna. Donec egestas nec lacus at sagittis. Nullam nec sem fermentum, porttitor lectus eu, tempus sem.Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Sed tempor feugiat mi. Sed convallis pulvinar ex, ac vehicula lorem facilisis ut. Quisque eleifend dolor euismod tincidunt consequat. Quisque porta sapien non est maximus condimentum.Quisque ornare magna at accumsan maximus. Morbi lobortis, magna sit amet euismod euismod, tortor sapien faucibus elit, sit amet semper magna dolor ut eros.Aenean nec dolor at lorem accumsan pulvinar.Proin consequat, lorem quis porta blandit, libero orci viverra lectus, non vehicula libero augue a felis.Ut pharetra, erat nec ultrices facilisis, diam turpis luctus ante, tincidunt lobortis leo elit vitae dolor.Maecenas in scelerisque felis, eget lobortis nisi. Praesent elementum dui tempus auctor cursus. Nunc ac velit quis quam porta vehicula.Phasellus ac varius mauris. Duis malesuada ornare dictum. Proin eu metus quis dui convallis feugiat nec vel magna. Donec commodo tellus quis nulla interdum, vel maximus nisi accumsan.Etiam porttitor nunc ultrices euismod vehicula. Donec eget consectetur quam, sit amet auctor ante.Etiam sit amet ipsum at erat lobortis pellentesque eu quis felis.Morbi sollicitudin ligula augue, id sagittis nisl ullamcorper ullamcorper. Pellentesque fringilla eleifend lorem non volutpat. Vestibulum eu metus eu urna pretium pellentesque a eu neque. Nullam ac lacus blandit, gravida justo at, volutpat justo.Nunc vitae tristique massa. Cras placerat egestas ex id cursus. Mauris ut turpis neque. Fusce dapibus fermentum odio non suscipit. Donec nec odio non nibh hendrerit eleifend.Mauris nulla enim, pretium in sapien eu, dapibus feugiat mauris. Nam id maximus neque. Integer pharetra risus eu augue rutrum, eget pretium nisi lobortis.Maecenas luctus mauris malesuada ornare gravida. Etiam interdum magna sed orci bibendum sodales.Duis in elit ipsum. Integer porta massa non arcu mattis eleifend.Duis mattis mollis metus, id facilisis libero faucibus in. Integer augue orci, suscipit vitae ultricies a, viverra maximus purus. Praesent ullamcorper libero nisi, sed placerat neque interdum vitae. Nam mollis ultricies velit, tincidunt egestas odio sodales non. Curabitur accumsan risus ut tellus ultricies mollis. ";
                        g.Children.Add(t);
                        myContent.Content = g;
                        break;
                    }
            }
            if (screenStates.CurrentState == Narrow)
            {
                splitView.IsPaneOpen = false;
            }
        }
    }
}
