using CPS714_Loyalty_Rewards_API.Models.Tables;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CPS714_Loyalty_Rewards_API.Data
{
    public class LoyaltyRewardsDbContext : DbContext
    {
        public LoyaltyRewardsDbContext(DbContextOptions<LoyaltyRewardsDbContext> options) : base(options)
        {
        }

        public DbSet<FeedbackFormData> FeedbackFormData { get; set; }
        public DbSet<FeedbackFormTopics> FeedbackFormTopics { get; set; }

        public DbSet<SurveyData> SurveyData { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<FeedbackFormData>(entity =>
            {
                entity.HasKey(e => e.ID);
            });

            builder.Entity<FeedbackFormTopics>(entity =>
            {
                entity.HasKey(e => e.UID);
            });

            builder.Entity<SurveyData>(entity =>
            {
                entity.HasKey(e => e.ID);
            });

        }
    }
}
