using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class GroupTerm
    {
        public int Id { get; set; }
        public int IdGroup { get; set; }
        public int IdTerm { get; set; }
        public bool? Status { get; set; }

        public Group IdGroupNavigation { get; set; }
        public TermToSearch IdTermNavigation { get; set; }
    }
}
