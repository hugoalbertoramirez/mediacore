using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class PublisherIndicator
    {
        public PublisherIndicator()
        {
            Publisher = new HashSet<Publisher>();
        }

        public int Id { get; set; }
        public string Importance { get; set; }
        public string Classification { get; set; }
        public string Description { get; set; }
        public bool? Status { get; set; }

        public ICollection<Publisher> Publisher { get; set; }
    }
}
