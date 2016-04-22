using ResponsiveDesign.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiveDesign.ViewModels
{
    public class PicturesViewModel
    {
        public List<Picture> SpotlightPictures { get; set; }
        public List<Picture> NewPictures { get; set; }
        public List<Picture> TopRatedPictures { get; set; }
     
        public PicturesViewModel()
        {
            var list = new List<Picture>();
            list.Add(new Picture { Title = "The railroad goes into the distance", Category = PictureCategory.LANDSCAPE, ImageUrl = "/Images/Landscape/railroad.jpg" });
            list.Add(new Picture { Title = "Prague Astronomical Clock", Category = PictureCategory.ARCHITECTURE, ImageUrl = "/Images/Architecture/prague-clock.jpg" });
            list.Add(new Picture { Title = "Majestic Lion", Category = PictureCategory.NATURE, ImageUrl = "/Images/Nature/lion.jpg" });
            list.Add(new Picture { Title = "Monarch Butterfly", Category = PictureCategory.NATURE, ImageUrl = "/Images/Nature/butterfly.jpg" });
            list.Add(new Picture { Title = "Stormy Weather", Category = PictureCategory.LANDSCAPE, ImageUrl = "/Images/Landscape/storm.jpg" });
            SpotlightPictures = list;

            list = new List<Picture>();
            list.Add(new Picture { Title = "Fast Flowing River", Category = PictureCategory.LANDSCAPE, ImageUrl = "/Images/Landscape/river.jpg" });
            list.Add(new Picture { Title = "Tropical Paradise", Category = PictureCategory.LANDSCAPE, ImageUrl = "/Images/Landscape/tropical-paradise.jpg" });
            list.Add(new Picture { Title = "Yellow Autumn", Category = PictureCategory.LANDSCAPE, ImageUrl = "/Images/Landscape/autumn.jpg" });
            list.Add(new Picture { Title = "Empire State Building", Category = PictureCategory.ARCHITECTURE, ImageUrl = "/Images/Architecture/empire-state-building.jpg" });
            list.Add(new Picture { Title = "Glass Tunnel", Category = PictureCategory.ARCHITECTURE, ImageUrl = "/Images/Architecture/glass-tunnel.jpg" });
            list.Add(new Picture { Title = "Tower Bridge at Night", Category = PictureCategory.ARCHITECTURE, ImageUrl = "/Images/Architecture/tower-bridge.jpg" });
            list.Add(new Picture { Title = "Westminster Abbey", Category = PictureCategory.ARCHITECTURE, ImageUrl = "/Images/Architecture/westminster-abbey.jpg" });
            list.Add(new Picture { Title = "Snow Owl", Category = PictureCategory.NATURE, ImageUrl = "/Images/Nature/owl.jpg" });
            list.Add(new Picture { Title = "Stingray", Category = PictureCategory.NATURE, ImageUrl = "/Images/Nature/stingray.jpg" });
            list.Add(new Picture { Title = "Swan On Lake", Category = PictureCategory.NATURE, ImageUrl = "/Images/Nature/swan.jpg" });
            list.Add(new Picture { Title = "The railroad goes into the distance", Category = PictureCategory.LANDSCAPE, ImageUrl = "/Images/Landscape/railroad.jpg" });
            list.Add(new Picture { Title = "Prague Astronomical Clock", Category = PictureCategory.ARCHITECTURE, ImageUrl = "/Images/Architecture/prague-clock.jpg" });
            list.Add(new Picture { Title = "Majestic Lion", Category = PictureCategory.NATURE, ImageUrl = "/Images/Nature/lion.jpg" });
            list.Add(new Picture { Title = "Monarch Butterfly", Category = PictureCategory.NATURE, ImageUrl = "/Images/Nature/butterfly.jpg" });
            list.Add(new Picture { Title = "Stormy Weather", Category = PictureCategory.LANDSCAPE, ImageUrl = "/Images/Landscape/storm.jpg" });

            Random r = new Random();
            TopRatedPictures = list.OrderBy(p => r.Next()).ToList();
            NewPictures = list.OrderBy(p => r.Next()).ToList();
            
        }
    }
}
