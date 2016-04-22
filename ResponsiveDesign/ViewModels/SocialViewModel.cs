using ResponsiveDesign.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiveDesign.ViewModels
{
    public class SocialViewModel
    {
        public List<SocialActivity> ActivityList { get; set; }

        public SocialViewModel()
        {
            ActivityList = new List<SocialActivity>();

            ActivityList.Add(new SocialActivity
            {
                Username = "Nuno Silva",
                Action = "downloaded a picture",
                Avatar = "/Images/nunosilva.jpg",
                Picture = new Picture
                {
                    Title = "Majestic Lion",
                    ImageUrl = "/Images/Nature/lion.jpg"
                }
            });

            ActivityList.Add(new SocialActivity
            {
                Username = "John Doe",
                Action = "gave a 3 star rating to",
                Picture = new Picture
                {
                    Title = "Yellow Autumn",
                    ImageUrl = "/Images/landscape/autumn.jpg"
                }
            });

            ActivityList.Add(new SocialActivity
            {
                Username = "Nuno Silva",
                Avatar = "/Images/nunosilva.jpg",
                Action = "uploaded a new picture",
                Picture = new Picture
                {
                    Title = "Glass Tunnel",
                    ImageUrl = "/Images/architecture/glass-tunnel.jpg"
                }
            });

            ActivityList.Add(new SocialActivity
            {
                Username = "John Doe",
                Action = "gave a 4 star rating to",
                Picture = new Picture
                {
                    Title = "Stormy Weather",
                    ImageUrl = "/Images/landscape/storm.jpg"
                }
            });
        }
    }
}
