using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class TermToSearch
    {
        public TermToSearch()
        {
            GroupTerm = new HashSet<GroupTerm>();
            NewsTermToSearch = new HashSet<NewsTermToSearch>();
            VideoTermToSearch = new HashSet<VideoTermToSearch>();
        }

        public int Id { get; set; }
        public string Term { get; set; }
        public bool IsTrending { get; set; }
        public bool? Status { get; set; }

        public ICollection<GroupTerm> GroupTerm { get; set; }
        public ICollection<NewsTermToSearch> NewsTermToSearch { get; set; }
        public ICollection<VideoTermToSearch> VideoTermToSearch { get; set; }
    }
}
