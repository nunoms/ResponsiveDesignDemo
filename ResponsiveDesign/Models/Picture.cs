using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiveDesign.Models
{
    public enum PictureCategory { ARCHITECTURE, NATURE, LANDSCAPE }
    public class Picture
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public PictureCategory Category { get; set; }
    }
}
