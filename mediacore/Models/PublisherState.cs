using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class PublisherState
    {
        public int Id { get; set; }
        public int IdPublisher { get; set; }
        public int IdState { get; set; }
        public bool? Status { get; set; }

        public Publisher IdPublisherNavigation { get; set; }
        public State IdStateNavigation { get; set; }
    }
}
