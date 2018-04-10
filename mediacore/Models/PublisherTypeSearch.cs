using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class PublisherTypeSearch
    {
        public PublisherTypeSearch()
        {
            PublisherPublisherTypeSearch = new HashSet<PublisherPublisherTypeSearch>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }

        public ICollection<PublisherPublisherTypeSearch> PublisherPublisherTypeSearch { get; set; }
    }
}
