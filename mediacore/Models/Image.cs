using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class Image
    {
        public int Id { get; set; }
        public string ContentUrl { get; set; }
        public string ThumbnailContentUrl { get; set; }
        public int? ThumbnailWidth { get; set; }
        public int? ThumbnailHeight { get; set; }
        public bool? Status { get; set; }
        public int IdNews { get; set; }

        public News IdNewsNavigation { get; set; }
    }
}
