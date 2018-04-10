using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class NewsPublisher
    {
        public int Id { get; set; }
        public int IdNews { get; set; }
        public int IdPublisher { get; set; }
        public bool? Status { get; set; }

        public News IdNewsNavigation { get; set; }
        public Publisher IdPublisherNavigation { get; set; }
    }
}
