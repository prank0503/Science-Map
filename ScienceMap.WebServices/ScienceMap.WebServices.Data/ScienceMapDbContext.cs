using Microsoft.EntityFrameworkCore;
using ScienceMap.WebServices.Data.Models;
using System;

namespace ScienceMap.WebServices.Data
{
    public class ScienceMapDbContext : DbContext
    {
        public ScienceMapDbContext(DbContextOptions options) : base(options)
        {
        }

        // SCS tables
        DbSet<ClassificationSubject> ClassificationSubject { get; set; }
        DbSet<ClassificationSubjectDiscussion> ClassificationSubjectDiscussion { get; set; }
        DbSet<ClassificationSubjectPublication> ClassificationSubjectPublication { get; set; }
        DbSet<ClassificationSubjectPublicationState> ClassificationSubjectPublicationState { get; set; }
        DbSet<ClassificationSubjectRelation> ClassificationSubjectRelation { get; set; }
        DbSet<ClassificationSubjectState> ClassificationSubjectState { get; set; }
        DbSet<ClassificationSubjectSuggestion> ClassificationSubjectSuggestion { get; set; }
        DbSet<ClassificationSubjectUser> ClassificationSubjectUser { get; set; }
        DbSet<ClassificationSubjectUserRole> ClassificationSubjectUserRole { get; set; }

        // Author tables
        DbSet<AuthorName> AuthorName { get; set; }

        // Discussion tables
        DbSet<Discussion> Discussion { get; set; }
        DbSet<DiscussionEntry> DiscussionEntry { get; set; }
        DbSet<DiscussionType> DiscussionType { get; set; }

        //Organisation tables
        DbSet<Organisation> Organisation { get; set; }
        DbSet<OrganisationState> OrganisationState { get; set; }
        DbSet<OrganisationType> OrganisationType { get; set; }

        // Publication Influence tables
        DbSet<PubInfluence> PubInfluence { get; set; }
        DbSet<PubInfluenceRate> PubInfluenceRate { get; set; }
        DbSet<PubInfluenceRateType> PubInfluenceRateType { get; set; }
        DbSet<PubInfluenceType> PubInfluenceType { get; set; }
        DbSet<PubInfluenceTypeAssessment> PubInfluenceTypeAssessment { get; set; }
        DbSet<PubInfluenceTypeState> PubInfluenceTypeState { get; set; }
        DbSet<PubInfluenceTypeSuggestion> PubInfluenceTypeSuggestion { get; set; }

        // Publication tables
        DbSet<Publication> Publication { get; set; }
        DbSet<PublicationAuthor> PublicationAuthor { get; set; }
        DbSet<PublicationState> PublicationState { get; set; }

        // User related tables
        DbSet<User> User { get; set; }
        DbSet<UserAuthor> UserAuthor { get; set; }
        DbSet<UserFavAuthor> UserFavAuthor { get; set; }
        DbSet<UserFavClassificationSubject> UserFavClassificationSubject { get; set; }
        DbSet<UserFollowerDiscussion> UserFollowerDiscussion { get; set; }
        DbSet<UserOrganisation> UserOrganisation { get; set; }
        DbSet<UserRole> UserRole { get; set; }
        DbSet<UserRoleType> UserRoleType { get; set; }
        DbSet<UserState> UserState { get; set; }

        // TODO: Rename the table column as its confusing and identical to other table
        DbSet<UserScsMapping> UserScsMapping { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorName>()
                .HasAlternateKey(c => c.FirstName)
                .HasName("AlternateKey_FirstName");


            modelBuilder.Entity<ClassificationSubjectRelation>()
                .HasOne(m => m.ClassificationSubject)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PubInfluence>()
                .HasOne(m => m.PublicationTarget)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PubInfluenceRate>()
                .HasOne(m => m.User)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserFavAuthor>()
                .HasOne(m => m.User)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
