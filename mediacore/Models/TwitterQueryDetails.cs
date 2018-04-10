using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class TwitterQueryDetails
    {
        public int Id { get; set; }
        public int ReadableId { get; set; }
        public string Operator { get; set; }
        public string Operand { get; set; }
    }
}
