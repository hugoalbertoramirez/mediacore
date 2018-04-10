using System;
using System.Collections.Generic;

namespace mediacore.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            MainPublisher = new HashSet<MainPublisher>();
            NewsPublisher = new HashSet<NewsPublisher>();
            PublisherCountry = new HashSet<PublisherCountry>();
            PublisherPublisherType = new HashSet<PublisherPublisherType>();
            PublisherPublisherTypeSearch = new HashSet<PublisherPublisherTypeSearch>();
            PublisherState = new HashSet<PublisherState>();
            Video = new HashSet<Video>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? IdPublisherIndicator { get; set; }
        public bool? Status { get; set; }

        public PublisherIndicator IdPublisherIndicatorNavigation { get; set; }
        public ICollection<MainPublisher> MainPublisher { get; set; }
        public ICollection<NewsPublisher> NewsPublisher { get; set; }
        public ICollection<PublisherCountry> PublisherCountry { get; set; }
        public ICollection<PublisherPublisherType> PublisherPublisherType { get; set; }
        public ICollection<PublisherPublisherTypeSearch> PublisherPublisherTypeSearch { get; set; }
        public ICollection<PublisherState> PublisherState { get; set; }
        public ICollection<Video> Video { get; set; }
    }
}
