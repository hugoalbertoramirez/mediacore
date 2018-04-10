using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class TweetsProcessed
    {
        public string Tweetid { get; set; }
        public DateTime? Dateorig { get; set; }
        public DateTime? Hourofdate { get; set; }
        public DateTime? Minuteofdate { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Masterid { get; set; }
        public string Retweet { get; set; }
        public string Username { get; set; }
        public string Userlocation { get; set; }
        public string Usernumber { get; set; }
        public string ImageUrl { get; set; }
        public string AuthorimageUrl { get; set; }
        public string Direction { get; set; }
        public int? Favorited { get; set; }
        public int? UserFollowers { get; set; }
        public int? UserFriends { get; set; }
        public int? UserFavorites { get; set; }
        public int? UserTotaltweets { get; set; }

        public TweetsNormalized Master { get; set; }
    }
}
