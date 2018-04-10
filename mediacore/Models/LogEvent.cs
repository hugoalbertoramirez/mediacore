using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class LogEvent
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdEvent { get; set; }
        public int? IdState { get; set; }
        public int? IdPublisherType { get; set; }
        public int? IdTermToSearch { get; set; }
        public string Search { get; set; }
        public DateTime DateUpload { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public bool? Status { get; set; }

        public Event IdEventNavigation { get; set; }
        public LogEvent IdNavigation { get; set; }
        public LogEvent InverseIdNavigation { get; set; }
    }
}
