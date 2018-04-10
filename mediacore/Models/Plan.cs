using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class Plan
    {
        public Plan()
        {
            Consumption = new HashSet<Consumption>();
            PlanProduct = new HashSet<PlanProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int IdPeriod { get; set; }
        public int IdLicense { get; set; }
        public int IdSector { get; set; }
        public bool? Status { get; set; }
        public int Users { get; set; }

        public Period IdPeriodNavigation { get; set; }
        public Sector IdSectorNavigation { get; set; }
        public ICollection<Consumption> Consumption { get; set; }
        public ICollection<PlanProduct> PlanProduct { get; set; }
    }
}
