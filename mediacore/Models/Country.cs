using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class Country
    {
        public Country()
        {
            PublisherCountry = new HashSet<PublisherCountry>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }

        public ICollection<PublisherCountry> PublisherCountry { get; set; }
    }
}
