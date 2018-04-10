using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class News
    {
        public News()
        {
            FavoriteNews = new HashSet<FavoriteNews>();
            Image = new HashSet<Image>();
            ImportantNews = new HashSet<ImportantNews>();
            NewsAbout = new HashSet<NewsAbout>();
            NewsKeyPhrase = new HashSet<NewsKeyPhrase>();
            NewsMention = new HashSet<NewsMention>();
            NewsPublisher = new HashSet<NewsPublisher>();
            NewsTermToSearch = new HashSet<NewsTermToSearch>();
            NewsVideo = new HashSet<NewsVideo>();
        }

        public int Id { get; set; }
        public int? IdCategory { get; set; }
        public DateTime? DatePublished { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public bool? Status { get; set; }
        public int? IdOpinion { get; set; }
        public int? IdClassification { get; set; }

        public Category IdCategoryNavigation { get; set; }
        public Classification IdClassificationNavigation { get; set; }
        public Opinion IdOpinionNavigation { get; set; }
        public ICollection<FavoriteNews> FavoriteNews { get; set; }
        public ICollection<Image> Image { get; set; }
        public ICollection<ImportantNews> ImportantNews { get; set; }
        public ICollection<NewsAbout> NewsAbout { get; set; }
        public ICollection<NewsKeyPhrase> NewsKeyPhrase { get; set; }
        public ICollection<NewsMention> NewsMention { get; set; }
        public ICollection<NewsPublisher> NewsPublisher { get; set; }
        public ICollection<NewsTermToSearch> NewsTermToSearch { get; set; }
        public ICollection<NewsVideo> NewsVideo { get; set; }
    }
}
