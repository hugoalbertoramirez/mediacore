using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class FavoriteVideo
    {
        public int Id { get; set; }
        public int IdVideo { get; set; }
        public int IdUser { get; set; }
        public bool? Status { get; set; }

        public User IdUserNavigation { get; set; }
        public Video IdVideoNavigation { get; set; }
    }
}
