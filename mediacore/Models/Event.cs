using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class Event
    {
        public Event()
        {
            LogEvent = new HashSet<LogEvent>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Status { get; set; }

        public ICollection<LogEvent> LogEvent { get; set; }
    }
}
