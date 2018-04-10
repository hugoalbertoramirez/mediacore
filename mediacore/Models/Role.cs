using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class Role
    {
        public Role()
        {
            RolePermission = new HashSet<RolePermission>();
            User = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }

        public ICollection<RolePermission> RolePermission { get; set; }
        public ICollection<User> User { get; set; }
    }
}
