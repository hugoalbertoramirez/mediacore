using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public bool? Status1 { get; set; }
    }
}
