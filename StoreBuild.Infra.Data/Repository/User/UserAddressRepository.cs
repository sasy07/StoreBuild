using StoreBuild.Domain.Interfaces.User;

namespace StoreBuild.Infra.Data.Repository.User
{
    public class UserAddressRepository:IUserAddressRepository
    {
        private StoreBuildDbContext _context;

        public UserAddressRepository(StoreBuildDbContext context)
        {
            _context = context;
        }
    }
}