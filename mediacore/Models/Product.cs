using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class Product
    {
        public Product()
        {
            PlanProduct = new HashSet<PlanProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Level { get; set; }
        public double Price { get; set; }
        public int TransactionsAllowed { get; set; }
        public string Url { get; set; }
        public string UrlDocumentation { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool? Status { get; set; }

        public ICollection<PlanProduct> PlanProduct { get; set; }
    }
}
