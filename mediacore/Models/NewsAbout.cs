using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class NewsAbout
    {
        public int Id { get; set; }
        public int IdNews { get; set; }
        public int IdAbout { get; set; }
        public bool? Status { get; set; }

        public About IdAboutNavigation { get; set; }
        public News IdNewsNavigation { get; set; }
    }
}
