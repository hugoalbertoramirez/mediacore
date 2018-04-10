using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class Permission
    {
        public Permission()
        {
            RolePermission = new HashSet<RolePermission>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }

        public ICollection<RolePermission> RolePermission { get; set; }
    }
}
