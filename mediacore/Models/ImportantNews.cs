﻿using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class ImportantNews
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdNews { get; set; }
        public bool? Status { get; set; }

        public News IdNewsNavigation { get; set; }
        public User IdUserNavigation { get; set; }
    }
}
