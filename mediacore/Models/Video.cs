using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class Video
    {
        public Video()
        {
            FavoriteVideo = new HashSet<FavoriteVideo>();
            NewsVideo = new HashSet<NewsVideo>();
            UserVideo = new HashSet<UserVideo>();
            VideoIndexer = new HashSet<VideoIndexer>();
            VideoKeyPhrase = new HashSet<VideoKeyPhrase>();
            VideoOpinion = new HashSet<VideoOpinion>();
            VideoTermToSearch = new HashSet<VideoTermToSearch>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? DatePublished { get; set; }
        public int? IdPublisher { get; set; }
        public int? IdCreator { get; set; }
        public string ContentUrl { get; set; }
        public string HostPageUrl { get; set; }
        public int? IdEncodingFormat { get; set; }
        public string HostPageDisplayUrl { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public TimeSpan? Duration { get; set; }
        public string EmbedHtml { get; set; }
        public bool? AllowHttpsEmbed { get; set; }
        public int? ViewCount { get; set; }
        public int? ThumbnailWidth { get; set; }
        public int? ThumbnailHeight { get; set; }
        public string VideoId { get; set; }
        public bool? AllowMobileEmbed { get; set; }
        public string Name { get; set; }
        public string ThumbnailUrl { get; set; }
        public string WebSearchUrl { get; set; }
        public string MotionThumbnailUrl { get; set; }
        public bool? Status { get; set; }

        public Creator IdCreatorNavigation { get; set; }
        public EncodingFormat IdEncodingFormatNavigation { get; set; }
        public Publisher IdPublisherNavigation { get; set; }
        public ICollection<FavoriteVideo> FavoriteVideo { get; set; }
        public ICollection<NewsVideo> NewsVideo { get; set; }
        public ICollection<UserVideo> UserVideo { get; set; }
        public ICollection<VideoIndexer> VideoIndexer { get; set; }
        public ICollection<VideoKeyPhrase> VideoKeyPhrase { get; set; }
        public ICollection<VideoOpinion> VideoOpinion { get; set; }
        public ICollection<VideoTermToSearch> VideoTermToSearch { get; set; }
    }
}
