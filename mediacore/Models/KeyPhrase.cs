using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class KeyPhrase
    {
        public KeyPhrase()
        {
            NewsKeyPhrase = new HashSet<NewsKeyPhrase>();
            VideoKeyPhrase = new HashSet<VideoKeyPhrase>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }

        public ICollection<NewsKeyPhrase> NewsKeyPhrase { get; set; }
        public ICollection<VideoKeyPhrase> VideoKeyPhrase { get; set; }
    }
}
