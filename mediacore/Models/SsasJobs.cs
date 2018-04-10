using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class SsasJobs
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string StatusMessage { get; set; }
        public int? LastCount { get; set; }
    }
}
