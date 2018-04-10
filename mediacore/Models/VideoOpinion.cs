using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class VideoOpinion
    {
        public int Id { get; set; }
        public int IdVideo { get; set; }
        public int IdOpinion { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool? Status { get; set; }

        public Opinion IdOpinionNavigation { get; set; }
        public Video IdVideoNavigation { get; set; }
    }
}
