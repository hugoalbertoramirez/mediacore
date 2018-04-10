using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class PublisherPublisherTypeSearch
    {
        public int Id { get; set; }
        public int? IdPublisher { get; set; }
        public int? IdPublisherTypeSearch { get; set; }
        public bool? Status { get; set; }

        public Publisher IdPublisherNavigation { get; set; }
        public PublisherTypeSearch IdPublisherTypeSearchNavigation { get; set; }
    }
}
