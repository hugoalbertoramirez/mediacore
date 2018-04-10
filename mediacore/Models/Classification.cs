using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class Classification
    {
        public Classification()
        {
            News = new HashSet<News>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }

        public ICollection<News> News { get; set; }
    }
}
