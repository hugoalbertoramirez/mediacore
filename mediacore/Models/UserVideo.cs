using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class UserVideo
    {
        public int Id { get; set; }
        public int IdGroup { get; set; }
        public int IdVideo { get; set; }

        public Group IdGroupNavigation { get; set; }
        public Video IdVideoNavigation { get; set; }
    }
}
