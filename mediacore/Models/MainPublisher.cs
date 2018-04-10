using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class MainPublisher
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int? IdPublisher { get; set; }
        public bool? Status { get; set; }

        public Publisher IdPublisherNavigation { get; set; }
    }
}
