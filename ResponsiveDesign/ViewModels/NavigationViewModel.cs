using ResponsiveDesign.Models;
using ResponsiveDesign.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiveDesign.ViewModels
{
    public class NavigationViewModel
    {
        public List<NavigationItem> NavLinks { get; set; }

        public NavigationViewModel()
        {
            NavLinks = new List<NavigationItem>();
            NavLinks.Add(new NavigationItem { Label = "Resize", Number="1", PageType = typeof(Resize) });
            NavLinks.Add(new NavigationItem { Label = "Reflow", Number="2", PageType = typeof(Reflow) });
            NavLinks.Add(new NavigationItem { Label = "Advanced Reflow", Number="2.1", PageType = typeof(AdvancedReflow) });
            NavLinks.Add(new NavigationItem { Label = "Reposition", Number="3", PageType = typeof(Reposition) });
            NavLinks.Add(new NavigationItem { Label = "Reveal", Number="4", PageType = typeof(Reveal) });
            NavLinks.Add(new NavigationItem { Label = "Rearchitect", Number = "5", PageType = typeof(Rearchitect) });
            NavLinks.Add(new NavigationItem { Label = "Replace", Number = "6", PageType = typeof(Replace) });
            NavLinks.Add(new NavigationItem { Label = "Advanced Replace", Number = "6.1", PageType = typeof(AdvancedReplace) });
        }
    }
}
