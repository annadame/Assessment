using Microsoft.EntityFrameworkCore;

namespace SocialBrothersAssessment.Models
{
    public class AddressDbContext : DbContext
    {
        public AddressDbContext(DbContextOptions<AddressDbContext> options) : base(options) {}

        public DbSet<Address> Addresses { get; set; }
    }
}
