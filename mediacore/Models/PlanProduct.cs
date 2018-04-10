using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class PlanProduct
    {
        public int Id { get; set; }
        public int IdPlan { get; set; }
        public int IdProduct { get; set; }
        public bool? Status { get; set; }

        public Plan IdPlanNavigation { get; set; }
        public Product IdProductNavigation { get; set; }
    }
}
