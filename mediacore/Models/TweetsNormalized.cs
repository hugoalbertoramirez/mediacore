using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class TweetsNormalized
    {
        public TweetsNormalized()
        {
            TweetsProcessed = new HashSet<TweetsProcessed>();
        }

        public string Masterid { get; set; }
        public int? Mentions { get; set; }
        public int? Hashtags { get; set; }
        public string Tweet { get; set; }
        public string Twitterhandle { get; set; }
        public string Userlocation { get; set; }
        public string Usernumber { get; set; }
        public double? Sentiment { get; set; }
        public double? Sentimentbin { get; set; }
        public string Sentimentposneg { get; set; }
        public string Lang { get; set; }
        public string Accounttag { get; set; }

        public ICollection<TweetsProcessed> TweetsProcessed { get; set; }
    }
}
