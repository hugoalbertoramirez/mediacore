using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class About
    {
        public About()
        {
            NewsAbout = new HashSet<NewsAbout>();
        }

        public int Id { get; set; }
        public string ReadLink { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }

        public ICollection<NewsAbout> NewsAbout { get; set; }
    }
}
