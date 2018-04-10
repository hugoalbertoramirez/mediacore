using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class PublisherType
    {
        public PublisherType()
        {
            PublisherPublisherType = new HashSet<PublisherPublisherType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }

        public ICollection<PublisherPublisherType> PublisherPublisherType { get; set; }
    }
}
