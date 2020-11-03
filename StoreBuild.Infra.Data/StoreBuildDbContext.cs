using Microsoft.EntityFrameworkCore;
using StoreBuild.Domain.Models.User;

namespace StoreBuild.Infra.Data
{
    public class StoreBuildDbContext : DbContext
    {
        public StoreBuildDbContext(DbContextOptions<StoreBuildDbContext> options) : base(options)
        {
        }

        #region Users

        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<SecurityQuestion> SecurityQuestiones { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<UserDocument> UserDocuments { get; set; }
        public DbSet<UserSecurity> UserSecurities { get; set; }
        public DbSet<SecurityAnswer> SecurityAnswers { get; set; }

        #endregion
    }
}