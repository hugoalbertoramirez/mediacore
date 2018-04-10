using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class License
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int IdStatus { get; set; }
        public bool? Status { get; set; }
    }
}
