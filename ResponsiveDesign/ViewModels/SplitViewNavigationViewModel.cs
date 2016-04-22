using ResponsiveDesign.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ResponsiveDesign.ViewModels
{
    public class SplitViewNavigationViewModel
    {
        public List<SplitViewNavigationItem> NavLinks { get; set; }

        public SplitViewNavigationViewModel()
        {
            SetupNavigation();
        }

        private void SetupNavigation()
        {
            NavLinks = new List<SplitViewNavigationItem>();
            NavLinks.Add(new SplitViewNavigationItem { Label = "Home", Glyph = "\uE10F" });
            NavLinks.Add(new SplitViewNavigationItem { Label = "Top Pictures", Glyph = "\uE158" });
            NavLinks.Add(new SplitViewNavigationItem { Label = "Favorites", Glyph = "\uE1CE" });
            NavLinks.Add(new SplitViewNavigationItem { Label = "Feedback", Glyph = "\uE170" });
        }
    }

    
}
