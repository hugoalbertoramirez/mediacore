using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class RolePermission
    {
        public int Id { get; set; }
        public int IdRole { get; set; }
        public int IdPermission { get; set; }
        public bool? Status { get; set; }

        public Permission IdPermissionNavigation { get; set; }
        public Role IdRoleNavigation { get; set; }
    }
}
