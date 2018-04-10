using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class VideoIndexer
    {
        public int Id { get; set; }
        public int IdVideo { get; set; }
        public string IdVideoIndexer { get; set; }
        public string Url { get; set; }
        public string Thumbnail { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }

        public Video IdVideoNavigation { get; set; }
    }
}
