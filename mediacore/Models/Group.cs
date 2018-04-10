using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class Group
    {
        public Group()
        {
            Consumption = new HashSet<Consumption>();
            GroupTerm = new HashSet<GroupTerm>();
            User = new HashSet<User>();
            UserVideo = new HashSet<UserVideo>();
        }

        public int Id { get; set; }
        public int IdClient { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }
        public int? TimeVideo { get; set; }

        public Client IdClientNavigation { get; set; }
        public ICollection<Consumption> Consumption { get; set; }
        public ICollection<GroupTerm> GroupTerm { get; set; }
        public ICollection<User> User { get; set; }
        public ICollection<UserVideo> UserVideo { get; set; }
    }
}
