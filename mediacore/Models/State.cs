using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class State
    {
        public State()
        {
            PublisherState = new HashSet<PublisherState>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Initials { get; set; }
        public string Capital { get; set; }
        public bool? Status { get; set; }

        public ICollection<PublisherState> PublisherState { get; set; }
    }
}
