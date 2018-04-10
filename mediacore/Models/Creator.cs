using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class Creator
    {
        public Creator()
        {
            Video = new HashSet<Video>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }

        public ICollection<Video> Video { get; set; }
    }
}
