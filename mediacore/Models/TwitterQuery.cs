using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class TwitterQuery
    {
        public int Id { get; set; }
        public bool IsAdvanced { get; set; }
        public string QueryString { get; set; }
        public string TweetId { get; set; }
    }
}
