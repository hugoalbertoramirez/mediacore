using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class Mention
    {
        public Mention()
        {
            NewsMention = new HashSet<NewsMention>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }

        public ICollection<NewsMention> NewsMention { get; set; }
    }
}
