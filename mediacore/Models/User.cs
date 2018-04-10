using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class User
    {
        public User()
        {
            FavoriteNews = new HashSet<FavoriteNews>();
            FavoriteVideo = new HashSet<FavoriteVideo>();
            ImportantNews = new HashSet<ImportantNews>();
        }

        public int Id { get; set; }
        public int IdGroup { get; set; }
        public int IdRole { get; set; }
        public string User1 { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MLastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? Status { get; set; }
        public string LnToken { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateCreate { get; set; }

        public Group IdGroupNavigation { get; set; }
        public Role IdRoleNavigation { get; set; }
        public ICollection<FavoriteNews> FavoriteNews { get; set; }
        public ICollection<FavoriteVideo> FavoriteVideo { get; set; }
        public ICollection<ImportantNews> ImportantNews { get; set; }
    }
}
