using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class NewsVideo
    {
        public int Id { get; set; }
        public int IdNews { get; set; }
        public int IdVideo { get; set; }
        public bool? Status { get; set; }

        public News IdNewsNavigation { get; set; }
        public Video IdVideoNavigation { get; set; }
    }
}
