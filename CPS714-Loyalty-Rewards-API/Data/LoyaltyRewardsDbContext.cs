using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CPS714_Loyalty_Rewards_API.Data
{
    public class LoyaltyRewardsDbContext : DbContext
    {
        public LoyaltyRewardsDbContext(DbContextOptions<LoyaltyRewardsDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            
        }
    }
}
