using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using StoreBuild.Domain.Interfaces.User;
using StoreBuild.Domain.Models.User;

namespace StoreBuild.Infra.Data.Repository.User
{
    public class UserSecurityRepository:IUserSecurityRepository
    {
        private StoreBuildDbContext _context;

        public UserSecurityRepository(StoreBuildDbContext context)
        {
            _context = context;
        }

        public IEnumerable<UserSecurity> GetUserSecurities()
        {
            return _context.UserSecurities.Include(us => us.User);
        }
    }
}