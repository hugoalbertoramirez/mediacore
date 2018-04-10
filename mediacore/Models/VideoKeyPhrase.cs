using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class VideoKeyPhrase
    {
        public int Id { get; set; }
        public int IdVideo { get; set; }
        public int IdKeyPhrase { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool? Status { get; set; }

        public KeyPhrase IdKeyPhraseNavigation { get; set; }
        public Video IdVideoNavigation { get; set; }
    }
}
