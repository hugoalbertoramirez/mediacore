using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class NewsMention
    {
        public int Id { get; set; }
        public int IdNews { get; set; }
        public int IdMention { get; set; }
        public bool? Status { get; set; }

        public Mention IdMentionNavigation { get; set; }
        public News IdNewsNavigation { get; set; }
    }
}
