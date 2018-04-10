using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class Client
    {
        public Client()
        {
            Group = new HashSet<Group>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool? Status { get; set; }

        public ICollection<Group> Group { get; set; }
    }
}
