using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class NewsTermToSearch
    {
        public int Id { get; set; }
        public int IdNews { get; set; }
        public int IdTermToSearch { get; set; }
        public bool? Status { get; set; }

        public News IdNewsNavigation { get; set; }
        public TermToSearch IdTermToSearchNavigation { get; set; }
    }
}
