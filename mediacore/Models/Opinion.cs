using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class Opinion
    {
        public Opinion()
        {
            News = new HashSet<News>();
            VideoOpinion = new HashSet<VideoOpinion>();
        }

        public int Id { get; set; }
        public double Score { get; set; }
        public bool? Status { get; set; }

        public ICollection<News> News { get; set; }
        public ICollection<VideoOpinion> VideoOpinion { get; set; }
    }
}
