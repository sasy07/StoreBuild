using StoreBuild.Domain.Interfaces.User;

namespace StoreBuild.Infra.Data.Repository.User
{
    public class UserProfileRepository:IUserProfileRepository
    {
        private StoreBuildDbContext _context;

        public UserProfileRepository(StoreBuildDbContext context)
        {
            _context = context;
        }
    }
}