using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class Sector
    {
        public Sector()
        {
            Plan = new HashSet<Plan>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }

        public ICollection<Plan> Plan { get; set; }
    }
}
