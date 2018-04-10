using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class Consumption
    {
        public int Id { get; set; }
        public int IdGroup { get; set; }
        public int IdPlan { get; set; }
        public double ConsumptionAzure { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool? Status { get; set; }

        public Group IdGroupNavigation { get; set; }
        public Plan IdPlanNavigation { get; set; }
    }
}
