using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class FavoriteTweet
    {
        public int Id { get; set; }
        public int IdTweet { get; set; }
        public int IdUser { get; set; }
        public bool? Status { get; set; }
    }
}
