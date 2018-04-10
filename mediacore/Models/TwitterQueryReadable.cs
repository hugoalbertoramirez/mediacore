using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class TwitterQueryReadable
    {
        public int Id { get; set; }
        public int QueryId { get; set; }
        public string QueryReadable { get; set; }
        public string Query { get; set; }
    }
}
