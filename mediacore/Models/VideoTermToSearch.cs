using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class VideoTermToSearch
    {
        public int Id { get; set; }
        public int IdVideo { get; set; }
        public int IdTermToSearch { get; set; }
        public bool? Status { get; set; }

        public TermToSearch IdTermToSearchNavigation { get; set; }
        public Video IdVideoNavigation { get; set; }
    }
}
