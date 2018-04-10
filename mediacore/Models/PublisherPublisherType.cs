using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class PublisherPublisherType
    {
        public int Id { get; set; }
        public int IdPublisher { get; set; }
        public int IdType { get; set; }
        public bool? Status { get; set; }

        public Publisher IdPublisherNavigation { get; set; }
        public PublisherType IdTypeNavigation { get; set; }
    }
}
