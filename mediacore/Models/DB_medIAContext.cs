using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace mediacore.Models
{
    public partial class DB_medIAContext : DbContext
    {
        public virtual DbSet<About> About { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Classification> Classification { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Consumption> Consumption { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Creator> Creator { get; set; }
        public virtual DbSet<EncodingFormat> EncodingFormat { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<FavoriteNews> FavoriteNews { get; set; }
        public virtual DbSet<FavoriteTweet> FavoriteTweet { get; set; }
        public virtual DbSet<FavoriteVideo> FavoriteVideo { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<GroupTerm> GroupTerm { get; set; }
        public virtual DbSet<Image> Image { get; set; }
        public virtual DbSet<ImportantNews> ImportantNews { get; set; }
        public virtual DbSet<KeyPhrase> KeyPhrase { get; set; }
        public virtual DbSet<License> License { get; set; }
        public virtual DbSet<LogEvent> LogEvent { get; set; }
        public virtual DbSet<MainPublisher> MainPublisher { get; set; }
        public virtual DbSet<Mention> Mention { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsAbout> NewsAbout { get; set; }
        public virtual DbSet<NewsKeyPhrase> NewsKeyPhrase { get; set; }
        public virtual DbSet<NewsMention> NewsMention { get; set; }
        public virtual DbSet<NewsPublisher> NewsPublisher { get; set; }
        public virtual DbSet<NewsTermToSearch> NewsTermToSearch { get; set; }
        public virtual DbSet<NewsVideo> NewsVideo { get; set; }
        public virtual DbSet<Opinion> Opinion { get; set; }
        public virtual DbSet<OpinionLimit> OpinionLimit { get; set; }
        public virtual DbSet<Period> Period { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<Plan> Plan { get; set; }
        public virtual DbSet<PlanProduct> PlanProduct { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Publisher> Publisher { get; set; }
        public virtual DbSet<PublisherCountry> PublisherCountry { get; set; }
        public virtual DbSet<PublisherIndicator> PublisherIndicator { get; set; }
        public virtual DbSet<PublisherPublisherType> PublisherPublisherType { get; set; }
        public virtual DbSet<PublisherPublisherTypeSearch> PublisherPublisherTypeSearch { get; set; }
        public virtual DbSet<PublisherState> PublisherState { get; set; }
        public virtual DbSet<PublisherType> PublisherType { get; set; }
        public virtual DbSet<PublisherTypeSearch> PublisherTypeSearch { get; set; }
        public virtual DbSet<RegistroLand> RegistroLand { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RolePermission> RolePermission { get; set; }
        public virtual DbSet<Sector> Sector { get; set; }
        public virtual DbSet<SsasJobs> SsasJobs { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<TermToSearch> TermToSearch { get; set; }
        public virtual DbSet<TweetsNormalized> TweetsNormalized { get; set; }
        public virtual DbSet<TweetsProcessed> TweetsProcessed { get; set; }
        public virtual DbSet<TwitterQuery> TwitterQuery { get; set; }
        public virtual DbSet<TwitterQueryDetails> TwitterQueryDetails { get; set; }
        public virtual DbSet<TwitterQueryReadable> TwitterQueryReadable { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserVideo> UserVideo { get; set; }
        public virtual DbSet<Video> Video { get; set; }
        public virtual DbSet<VideoIndexer> VideoIndexer { get; set; }
        public virtual DbSet<VideoKeyPhrase> VideoKeyPhrase { get; set; }
        public virtual DbSet<VideoOpinion> VideoOpinion { get; set; }
        public virtual DbSet<VideoTermToSearch> VideoTermToSearch { get; set; }

        // Unable to generate entity type for table 'dbo.TestDateJC'. Please see the warning messages.
        // Unable to generate entity type for table 'pbist_twitter.configuration'. Please see the warning messages.
        // Unable to generate entity type for table 'pbist_twitter.hashtag_slicer'. Please see the warning messages.
        // Unable to generate entity type for table 'pbist_twitter.mention_slicer'. Please see the warning messages.
        // Unable to generate entity type for table 'pbist_twitter.authorhashtag_graph'. Please see the warning messages.
        // Unable to generate entity type for table 'pbist_twitter.authormention_graph'. Please see the warning messages.
        // Unable to generate entity type for table 'pbist_twitter.minimum_tweets'. Please see the warning messages.
        // Unable to generate entity type for table 'pbist_twitter.entityinitialcount'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_indicator'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_datos'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_dominio'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BK_Publisher_State'. Please see the warning messages.

        public DB_medIAContext(DbContextOptions<DB_medIAContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<About>(entity =>
            {
                entity.ToTable("About", "News");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ReadLink).HasColumnName("readLink");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category", "News");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Classification>(entity =>
            {
                entity.ToTable("Classification", "News");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client", "Control");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnName("registrationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Consumption>(entity =>
            {
                entity.ToTable("Consumption", "Control");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ConsumptionAzure).HasColumnName("consumptionAzure");

                entity.Property(e => e.EndDate).HasColumnName("endDate");

                entity.Property(e => e.IdGroup).HasColumnName("idGroup");

                entity.Property(e => e.IdPlan).HasColumnName("idPlan");

                entity.Property(e => e.StartDate).HasColumnName("startDate");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdGroupNavigation)
                    .WithMany(p => p.Consumption)
                    .HasForeignKey(d => d.IdGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Consumption_Group");

                entity.HasOne(d => d.IdPlanNavigation)
                    .WithMany(p => p.Consumption)
                    .HasForeignKey(d => d.IdPlan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Consumption_Plan");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Creator>(entity =>
            {
                entity.ToTable("Creator", "Video");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<EncodingFormat>(entity =>
            {
                entity.ToTable("EncodingFormat", "Video");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.ToTable("Event", "Control");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<FavoriteNews>(entity =>
            {
                entity.ToTable("Favorite_News", "News");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdNews).HasColumnName("idNews");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdNewsNavigation)
                    .WithMany(p => p.FavoriteNews)
                    .HasForeignKey(d => d.IdNews)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Favorite_News_News");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FavoriteNews)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Favorite_News_User");
            });

            modelBuilder.Entity<FavoriteTweet>(entity =>
            {
                entity.ToTable("Favorite_Tweet", "pbist_twitter");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdTweet).HasColumnName("idTweet");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<FavoriteVideo>(entity =>
            {
                entity.ToTable("Favorite_Video", "Video");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.IdVideo).HasColumnName("idVideo");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FavoriteVideo)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Favorite_Video_User");

                entity.HasOne(d => d.IdVideoNavigation)
                    .WithMany(p => p.FavoriteVideo)
                    .HasForeignKey(d => d.IdVideo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Favorite_Video_Video");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("Group", "Control");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdClient).HasColumnName("idClient");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TimeVideo).HasColumnName("timeVideo");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Group)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Group_Client");
            });

            modelBuilder.Entity<GroupTerm>(entity =>
            {
                entity.ToTable("Group_Term");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdGroup).HasColumnName("idGroup");

                entity.Property(e => e.IdTerm).HasColumnName("idTerm");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdGroupNavigation)
                    .WithMany(p => p.GroupTerm)
                    .HasForeignKey(d => d.IdGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Group_Term_Group");

                entity.HasOne(d => d.IdTermNavigation)
                    .WithMany(p => p.GroupTerm)
                    .HasForeignKey(d => d.IdTerm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Group_Term_TermToSearch");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.ToTable("Image", "News");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContentUrl).HasColumnName("contentUrl");

                entity.Property(e => e.IdNews).HasColumnName("idNews");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ThumbnailContentUrl).HasColumnName("thumbnailContentUrl");

                entity.Property(e => e.ThumbnailHeight).HasColumnName("thumbnailHeight");

                entity.Property(e => e.ThumbnailWidth).HasColumnName("thumbnailWidth");

                entity.HasOne(d => d.IdNewsNavigation)
                    .WithMany(p => p.Image)
                    .HasForeignKey(d => d.IdNews)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Image_News");
            });

            modelBuilder.Entity<ImportantNews>(entity =>
            {
                entity.ToTable("ImportantNews", "News");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdNews).HasColumnName("idNews");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdNewsNavigation)
                    .WithMany(p => p.ImportantNews)
                    .HasForeignKey(d => d.IdNews)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImportantNews_News");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.ImportantNews)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImportantNews_User");
            });

            modelBuilder.Entity<KeyPhrase>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<License>(entity =>
            {
                entity.ToTable("License", "Control");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdStatus).HasColumnName("idStatus");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogEvent>(entity =>
            {
                entity.ToTable("LogEvent", "Control");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateEnd).HasColumnName("dateEnd");

                entity.Property(e => e.DateStart).HasColumnName("dateStart");

                entity.Property(e => e.DateUpload).HasColumnName("dateUpload");

                entity.Property(e => e.IdEvent).HasColumnName("idEvent");

                entity.Property(e => e.IdPublisherType).HasColumnName("idPublisherType");

                entity.Property(e => e.IdState).HasColumnName("idState");

                entity.Property(e => e.IdTermToSearch).HasColumnName("idTermToSearch");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.Search).HasColumnName("search");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.InverseIdNavigation)
                    .HasForeignKey<LogEvent>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LogEvent_LogEvent");

                entity.HasOne(d => d.IdEventNavigation)
                    .WithMany(p => p.LogEvent)
                    .HasForeignKey(d => d.IdEvent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LogEvent_Event");
            });

            modelBuilder.Entity<MainPublisher>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdPublisher).HasColumnName("idPublisher");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.HasOne(d => d.IdPublisherNavigation)
                    .WithMany(p => p.MainPublisher)
                    .HasForeignKey(d => d.IdPublisher)
                    .HasConstraintName("FK_Publisher_PublisherURL");
            });

            modelBuilder.Entity<Mention>(entity =>
            {
                entity.ToTable("Mention", "News");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.ToTable("News", "News");

                entity.HasIndex(e => e.DatePublished)
                    .HasName("datePublishedIndex");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DatePublished)
                    .HasColumnName("datePublished")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IdCategory).HasColumnName("idCategory");

                entity.Property(e => e.IdClassification).HasColumnName("idClassification");

                entity.Property(e => e.IdOpinion).HasColumnName("idOpinion");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Text).HasColumnName("text");

                entity.Property(e => e.Url).HasColumnName("url");

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.IdCategory)
                    .HasConstraintName("FK_News_Category");

                entity.HasOne(d => d.IdClassificationNavigation)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.IdClassification)
                    .HasConstraintName("FK_News_Classification");

                entity.HasOne(d => d.IdOpinionNavigation)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.IdOpinion)
                    .HasConstraintName("FK_News_Opinion");
            });

            modelBuilder.Entity<NewsAbout>(entity =>
            {
                entity.ToTable("News_About", "News");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdAbout).HasColumnName("idAbout");

                entity.Property(e => e.IdNews).HasColumnName("idNews");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdAboutNavigation)
                    .WithMany(p => p.NewsAbout)
                    .HasForeignKey(d => d.IdAbout)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_News_About_About");

                entity.HasOne(d => d.IdNewsNavigation)
                    .WithMany(p => p.NewsAbout)
                    .HasForeignKey(d => d.IdNews)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_News_About_News");
            });

            modelBuilder.Entity<NewsKeyPhrase>(entity =>
            {
                entity.ToTable("News_KeyPhrase", "News");

                entity.HasIndex(e => new { e.IdKeyPhrase, e.IdNews })
                    .HasName("nci_wi_News_KeyPhrase_0693D25E23EEECF7214D7BB8671DE06E");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdKeyPhrase).HasColumnName("idKeyPhrase");

                entity.Property(e => e.IdNews).HasColumnName("idNews");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdKeyPhraseNavigation)
                    .WithMany(p => p.NewsKeyPhrase)
                    .HasForeignKey(d => d.IdKeyPhrase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_News_KeyPhrase_KeyPhrase");

                entity.HasOne(d => d.IdNewsNavigation)
                    .WithMany(p => p.NewsKeyPhrase)
                    .HasForeignKey(d => d.IdNews)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_News_KeyPhrase_News");
            });

            modelBuilder.Entity<NewsMention>(entity =>
            {
                entity.ToTable("News_Mention", "News");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdMention).HasColumnName("idMention");

                entity.Property(e => e.IdNews).HasColumnName("idNews");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdMentionNavigation)
                    .WithMany(p => p.NewsMention)
                    .HasForeignKey(d => d.IdMention)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_News_Mentions_Mentions");

                entity.HasOne(d => d.IdNewsNavigation)
                    .WithMany(p => p.NewsMention)
                    .HasForeignKey(d => d.IdNews)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_News_Mentions_News");
            });

            modelBuilder.Entity<NewsPublisher>(entity =>
            {
                entity.ToTable("News_Publisher", "News");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdNews).HasColumnName("idNews");

                entity.Property(e => e.IdPublisher).HasColumnName("idPublisher");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdNewsNavigation)
                    .WithMany(p => p.NewsPublisher)
                    .HasForeignKey(d => d.IdNews)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_News_Publisher_News");

                entity.HasOne(d => d.IdPublisherNavigation)
                    .WithMany(p => p.NewsPublisher)
                    .HasForeignKey(d => d.IdPublisher)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_News_Publisher_Publisher");
            });

            modelBuilder.Entity<NewsTermToSearch>(entity =>
            {
                entity.ToTable("News_TermToSearch", "News");

                entity.HasIndex(e => new { e.IdNews, e.IdTermToSearch })
                    .HasName("IndexTermToSearch_idNews_IdTermTosearch");

                entity.HasIndex(e => new { e.IdTermToSearch, e.IdNews })
                    .HasName("nci_wi_News_TermToSearch_CF39663569EDA12A7EA18FF5C2F9145F");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdNews).HasColumnName("idNews");

                entity.Property(e => e.IdTermToSearch).HasColumnName("idTermToSearch");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdNewsNavigation)
                    .WithMany(p => p.NewsTermToSearch)
                    .HasForeignKey(d => d.IdNews)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_News_TermToSearch_News");

                entity.HasOne(d => d.IdTermToSearchNavigation)
                    .WithMany(p => p.NewsTermToSearch)
                    .HasForeignKey(d => d.IdTermToSearch)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_News_TermToSearch_TermToSearch");
            });

            modelBuilder.Entity<NewsVideo>(entity =>
            {
                entity.ToTable("News_Video", "News");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdNews).HasColumnName("idNews");

                entity.Property(e => e.IdVideo).HasColumnName("idVideo");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdNewsNavigation)
                    .WithMany(p => p.NewsVideo)
                    .HasForeignKey(d => d.IdNews)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_News_Video_News");

                entity.HasOne(d => d.IdVideoNavigation)
                    .WithMany(p => p.NewsVideo)
                    .HasForeignKey(d => d.IdVideo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_News_Video_Video");
            });

            modelBuilder.Entity<Opinion>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<OpinionLimit>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.LimitSup).HasColumnName("limitSup");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Period>(entity =>
            {
                entity.ToTable("Period", "Control");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("Permission", "Control");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.ToTable("Plan", "Control");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdLicense).HasColumnName("idLicense");

                entity.Property(e => e.IdPeriod).HasColumnName("idPeriod");

                entity.Property(e => e.IdSector).HasColumnName("idSector");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Users).HasColumnName("users");

                entity.HasOne(d => d.IdPeriodNavigation)
                    .WithMany(p => p.Plan)
                    .HasForeignKey(d => d.IdPeriod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plan_Period");

                entity.HasOne(d => d.IdSectorNavigation)
                    .WithMany(p => p.Plan)
                    .HasForeignKey(d => d.IdSector)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plan_Sector");
            });

            modelBuilder.Entity<PlanProduct>(entity =>
            {
                entity.ToTable("Plan_Product", "Control");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdPlan).HasColumnName("idPlan");

                entity.Property(e => e.IdProduct).HasColumnName("idProduct");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdPlanNavigation)
                    .WithMany(p => p.PlanProduct)
                    .HasForeignKey(d => d.IdPlan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plan_Product_Plan");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.PlanProduct)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plan_Product_Product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product", "Control");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.ExpirationDate).HasColumnName("expirationDate");

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasColumnName("level");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TransactionsAllowed).HasColumnName("transactionsAllowed");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url");

                entity.Property(e => e.UrlDocumentation)
                    .IsRequired()
                    .HasColumnName("urlDocumentation");
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdPublisherIndicator).HasColumnName("idPublisherIndicator");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdPublisherIndicatorNavigation)
                    .WithMany(p => p.Publisher)
                    .HasForeignKey(d => d.IdPublisherIndicator)
                    .HasConstraintName("FK_Publisher_PublisherIndicator");
            });

            modelBuilder.Entity<PublisherCountry>(entity =>
            {
                entity.ToTable("Publisher_Country");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCountry).HasColumnName("idCountry");

                entity.Property(e => e.IdPublisher).HasColumnName("idPublisher");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdCountryNavigation)
                    .WithMany(p => p.PublisherCountry)
                    .HasForeignKey(d => d.IdCountry)
                    .HasConstraintName("FK_Country_Publisher_Country");

                entity.HasOne(d => d.IdPublisherNavigation)
                    .WithMany(p => p.PublisherCountry)
                    .HasForeignKey(d => d.IdPublisher)
                    .HasConstraintName("FK_Publisher_Publisher_Country");
            });

            modelBuilder.Entity<PublisherIndicator>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Classification).HasColumnName("classification");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Importance).HasColumnName("importance");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<PublisherPublisherType>(entity =>
            {
                entity.ToTable("Publisher_PublisherType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdPublisher).HasColumnName("idPublisher");

                entity.Property(e => e.IdType).HasColumnName("idType");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdPublisherNavigation)
                    .WithMany(p => p.PublisherPublisherType)
                    .HasForeignKey(d => d.IdPublisher)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Publisher_PublisherType_Publisher");

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.PublisherPublisherType)
                    .HasForeignKey(d => d.IdType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Publisher_PublisherType_PublisherType");
            });

            modelBuilder.Entity<PublisherPublisherTypeSearch>(entity =>
            {
                entity.ToTable("Publisher_PublisherTypeSearch");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdPublisher).HasColumnName("idPublisher");

                entity.Property(e => e.IdPublisherTypeSearch).HasColumnName("idPublisherTypeSearch");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdPublisherNavigation)
                    .WithMany(p => p.PublisherPublisherTypeSearch)
                    .HasForeignKey(d => d.IdPublisher)
                    .HasConstraintName("FK_Publisher_Relation");

                entity.HasOne(d => d.IdPublisherTypeSearchNavigation)
                    .WithMany(p => p.PublisherPublisherTypeSearch)
                    .HasForeignKey(d => d.IdPublisherTypeSearch)
                    .HasConstraintName("FK_PublisherTypeSearch_Relation");
            });

            modelBuilder.Entity<PublisherState>(entity =>
            {
                entity.ToTable("Publisher_State");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdPublisher).HasColumnName("idPublisher");

                entity.Property(e => e.IdState)
                    .HasColumnName("idState")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdPublisherNavigation)
                    .WithMany(p => p.PublisherState)
                    .HasForeignKey(d => d.IdPublisher)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Publisher_State_Publisher");

                entity.HasOne(d => d.IdStateNavigation)
                    .WithMany(p => p.PublisherState)
                    .HasForeignKey(d => d.IdState)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Publisher_State_State");
            });

            modelBuilder.Entity<PublisherType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<PublisherTypeSearch>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<RegistroLand>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaInsercion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role", "Control");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<RolePermission>(entity =>
            {
                entity.ToTable("Role_Permission", "Control");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdPermission).HasColumnName("idPermission");

                entity.Property(e => e.IdRole).HasColumnName("idRole");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdPermissionNavigation)
                    .WithMany(p => p.RolePermission)
                    .HasForeignKey(d => d.IdPermission)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Role_Permission_Permission");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.RolePermission)
                    .HasForeignKey(d => d.IdRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Role_Permission_Role");
            });

            modelBuilder.Entity<Sector>(entity =>
            {
                entity.ToTable("Sector", "Control");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SsasJobs>(entity =>
            {
                entity.ToTable("ssas_jobs", "pbist_twitter");

                entity.HasIndex(e => new { e.StartTime, e.EndTime })
                    .HasName("nci_wi_ssas_jobs_5559FD5A0F528BB82B39D4D48DD16FD3");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EndTime)
                    .HasColumnName("endTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastCount).HasColumnName("lastCount");

                entity.Property(e => e.StartTime)
                    .HasColumnName("startTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatusMessage).HasColumnName("statusMessage");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Capital).HasColumnName("capital");

                entity.Property(e => e.Initials).HasColumnName("initials");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status", "Control");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .IsUnicode(false);

                entity.Property(e => e.Status1)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<TermToSearch>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsTrending).HasColumnName("isTrending");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Term)
                    .IsRequired()
                    .HasColumnName("term");
            });

            modelBuilder.Entity<TweetsNormalized>(entity =>
            {
                entity.HasKey(e => e.Masterid);

                entity.ToTable("tweets_normalized", "pbist_twitter");

                entity.Property(e => e.Masterid)
                    .HasColumnName("masterid")
                    .HasColumnType("nchar(25)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accounttag)
                    .HasColumnName("accounttag")
                    .HasColumnType("nchar(25)");

                entity.Property(e => e.Hashtags).HasColumnName("hashtags");

                entity.Property(e => e.Lang)
                    .HasColumnName("lang")
                    .HasColumnType("nchar(4)");

                entity.Property(e => e.Mentions).HasColumnName("mentions");

                entity.Property(e => e.Sentiment).HasColumnName("sentiment");

                entity.Property(e => e.Sentimentbin).HasColumnName("sentimentbin");

                entity.Property(e => e.Sentimentposneg)
                    .HasColumnName("sentimentposneg")
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.Tweet)
                    .HasColumnName("tweet")
                    .HasColumnType("nchar(500)");

                entity.Property(e => e.Twitterhandle)
                    .HasColumnName("twitterhandle")
                    .HasColumnType("nchar(100)");

                entity.Property(e => e.Userlocation)
                    .HasColumnName("userlocation")
                    .HasColumnType("nchar(100)");

                entity.Property(e => e.Usernumber)
                    .HasColumnName("usernumber")
                    .HasColumnType("nchar(100)");
            });

            modelBuilder.Entity<TweetsProcessed>(entity =>
            {
                entity.HasKey(e => e.Tweetid);

                entity.ToTable("tweets_processed", "pbist_twitter");

                entity.HasIndex(e => new { e.Masterid, e.Username, e.Dateorig })
                    .HasName("nci_wi_tweets_processed_055D57FFDB45B538BC19CCC85C0284A4");

                entity.HasIndex(e => new { e.Username, e.Masterid, e.Dateorig })
                    .HasName("nci_wi_tweets_processed_DC0B697A7D89FD6DA777B304AF13CEA0");

                entity.Property(e => e.Tweetid)
                    .HasColumnName("tweetid")
                    .HasColumnType("nchar(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuthorimageUrl)
                    .HasColumnName("authorimage_url")
                    .HasColumnType("nchar(200)");

                entity.Property(e => e.Dateorig)
                    .HasColumnName("dateorig")
                    .HasColumnType("datetime");

                entity.Property(e => e.Direction)
                    .HasColumnName("direction")
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Favorited).HasColumnName("favorited");

                entity.Property(e => e.Hourofdate)
                    .HasColumnName("hourofdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("image_url")
                    .HasColumnType("nchar(200)");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Masterid)
                    .HasColumnName("masterid")
                    .HasColumnType("nchar(25)");

                entity.Property(e => e.Minuteofdate)
                    .HasColumnName("minuteofdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Retweet)
                    .HasColumnName("retweet")
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.UserFavorites).HasColumnName("user_favorites");

                entity.Property(e => e.UserFollowers).HasColumnName("user_followers");

                entity.Property(e => e.UserFriends).HasColumnName("user_friends");

                entity.Property(e => e.UserTotaltweets).HasColumnName("user_totaltweets");

                entity.Property(e => e.Userlocation)
                    .HasColumnName("userlocation")
                    .HasColumnType("nchar(100)");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("nchar(100)");

                entity.Property(e => e.Usernumber)
                    .HasColumnName("usernumber")
                    .HasColumnType("nchar(100)");

                entity.HasOne(d => d.Master)
                    .WithMany(p => p.TweetsProcessed)
                    .HasForeignKey(d => d.Masterid)
                    .HasConstraintName("ck_masteridconst");
            });

            modelBuilder.Entity<TwitterQuery>(entity =>
            {
                entity.ToTable("twitter_query", "pbist_twitter");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.QueryString).IsRequired();

                entity.Property(e => e.TweetId).HasColumnType("nchar(20)");
            });

            modelBuilder.Entity<TwitterQueryDetails>(entity =>
            {
                entity.ToTable("twitter_query_details", "pbist_twitter");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Operand).IsRequired();

                entity.Property(e => e.Operator).IsRequired();
            });

            modelBuilder.Entity<TwitterQueryReadable>(entity =>
            {
                entity.ToTable("twitter_query_readable", "pbist_twitter");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Query).IsRequired();

                entity.Property(e => e.QueryReadable).IsRequired();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User", "Control");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreate).HasColumnName("dateCreate");

                entity.Property(e => e.DateUpdate).HasColumnName("dateUpdate");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email");

                entity.Property(e => e.IdGroup).HasColumnName("idGroup");

                entity.Property(e => e.IdRole).HasColumnName("idRole");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("lastName");

                entity.Property(e => e.LnToken).HasColumnName("ln_token");

                entity.Property(e => e.MLastName).HasColumnName("mLastName");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.User1)
                    .IsRequired()
                    .HasColumnName("user");

                entity.HasOne(d => d.IdGroupNavigation)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.IdGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Group");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.IdRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Role");
            });

            modelBuilder.Entity<UserVideo>(entity =>
            {
                entity.ToTable("User_Video");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdGroup).HasColumnName("idGroup");

                entity.Property(e => e.IdVideo).HasColumnName("idVideo");

                entity.HasOne(d => d.IdGroupNavigation)
                    .WithMany(p => p.UserVideo)
                    .HasForeignKey(d => d.IdGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Video_Group");

                entity.HasOne(d => d.IdVideoNavigation)
                    .WithMany(p => p.UserVideo)
                    .HasForeignKey(d => d.IdVideo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Video_Video");
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.ToTable("Video", "Video");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllowHttpsEmbed).HasColumnName("allowHttpsEmbed");

                entity.Property(e => e.AllowMobileEmbed).HasColumnName("allowMobileEmbed");

                entity.Property(e => e.ContentUrl).HasColumnName("contentUrl");

                entity.Property(e => e.DatePublished)
                    .HasColumnName("datePublished")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.EmbedHtml).HasColumnName("embedHtml");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.HostPageDisplayUrl).HasColumnName("hostPageDisplayUrl");

                entity.Property(e => e.HostPageUrl).HasColumnName("hostPageUrl");

                entity.Property(e => e.IdCreator)
                    .HasColumnName("idCreator")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdEncodingFormat).HasColumnName("idEncodingFormat");

                entity.Property(e => e.IdPublisher).HasColumnName("idPublisher");

                entity.Property(e => e.MotionThumbnailUrl).HasColumnName("motionThumbnailUrl");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ThumbnailHeight).HasColumnName("thumbnailHeight");

                entity.Property(e => e.ThumbnailUrl).HasColumnName("thumbnailUrl");

                entity.Property(e => e.ThumbnailWidth).HasColumnName("thumbnailWidth");

                entity.Property(e => e.VideoId).HasColumnName("videoId");

                entity.Property(e => e.ViewCount).HasColumnName("viewCount");

                entity.Property(e => e.WebSearchUrl).HasColumnName("webSearchUrl");

                entity.Property(e => e.Width).HasColumnName("width");

                entity.HasOne(d => d.IdCreatorNavigation)
                    .WithMany(p => p.Video)
                    .HasForeignKey(d => d.IdCreator)
                    .HasConstraintName("FK_Video_Creator");

                entity.HasOne(d => d.IdEncodingFormatNavigation)
                    .WithMany(p => p.Video)
                    .HasForeignKey(d => d.IdEncodingFormat)
                    .HasConstraintName("FK_Video_EncodingFormat");

                entity.HasOne(d => d.IdPublisherNavigation)
                    .WithMany(p => p.Video)
                    .HasForeignKey(d => d.IdPublisher)
                    .HasConstraintName("FK_Video_Publisher");
            });

            modelBuilder.Entity<VideoIndexer>(entity =>
            {
                entity.ToTable("VideoIndexer", "Video");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdVideo).HasColumnName("idVideo");

                entity.Property(e => e.IdVideoIndexer)
                    .IsRequired()
                    .HasColumnName("idVideoIndexer");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Thumbnail)
                    .IsRequired()
                    .HasColumnName("thumbnail");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url");

                entity.HasOne(d => d.IdVideoNavigation)
                    .WithMany(p => p.VideoIndexer)
                    .HasForeignKey(d => d.IdVideo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VideoIndexer_Video");
            });

            modelBuilder.Entity<VideoKeyPhrase>(entity =>
            {
                entity.ToTable("Video_KeyPhrase", "Video");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EndTime).HasColumnName("endTime");

                entity.Property(e => e.IdKeyPhrase).HasColumnName("idKeyPhrase");

                entity.Property(e => e.IdVideo).HasColumnName("idVideo");

                entity.Property(e => e.StartTime).HasColumnName("startTime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdKeyPhraseNavigation)
                    .WithMany(p => p.VideoKeyPhrase)
                    .HasForeignKey(d => d.IdKeyPhrase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Video_KeyPhrase_KeyPhrase");

                entity.HasOne(d => d.IdVideoNavigation)
                    .WithMany(p => p.VideoKeyPhrase)
                    .HasForeignKey(d => d.IdVideo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Video_KeyPhrase_Video");
            });

            modelBuilder.Entity<VideoOpinion>(entity =>
            {
                entity.ToTable("Video_Opinion", "Video");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EndTime).HasColumnName("endTime");

                entity.Property(e => e.IdOpinion).HasColumnName("idOpinion");

                entity.Property(e => e.IdVideo).HasColumnName("idVideo");

                entity.Property(e => e.StartTime).HasColumnName("startTime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdOpinionNavigation)
                    .WithMany(p => p.VideoOpinion)
                    .HasForeignKey(d => d.IdOpinion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Video_Opinion_Opinion");

                entity.HasOne(d => d.IdVideoNavigation)
                    .WithMany(p => p.VideoOpinion)
                    .HasForeignKey(d => d.IdVideo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Video_Opinion_Video");
            });

            modelBuilder.Entity<VideoTermToSearch>(entity =>
            {
                entity.ToTable("Video_TermToSearch");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdTermToSearch).HasColumnName("idTermToSearch");

                entity.Property(e => e.IdVideo).HasColumnName("idVideo");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdTermToSearchNavigation)
                    .WithMany(p => p.VideoTermToSearch)
                    .HasForeignKey(d => d.IdTermToSearch)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Video_TermToSearch_TermToSearch");

                entity.HasOne(d => d.IdVideoNavigation)
                    .WithMany(p => p.VideoTermToSearch)
                    .HasForeignKey(d => d.IdVideo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Video_TermToSearch_Video");
            });
        }
    }
}
