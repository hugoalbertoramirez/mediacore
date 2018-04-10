using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class PublisherCountry
    {
        public int Id { get; set; }
        public int? IdPublisher { get; set; }
        public int? IdCountry { get; set; }
        public bool? Status { get; set; }

        public Country IdCountryNavigation { get; set; }
        public Publisher IdPublisherNavigation { get; set; }
    }
}
