using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class NewsKeyPhrase
    {
        public int Id { get; set; }
        public int IdNews { get; set; }
        public int IdKeyPhrase { get; set; }
        public bool? Status { get; set; }

        public KeyPhrase IdKeyPhraseNavigation { get; set; }
        public News IdNewsNavigation { get; set; }
    }
}
