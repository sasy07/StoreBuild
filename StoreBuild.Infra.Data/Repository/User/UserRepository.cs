using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using StoreBuild.Domain.Interfaces.User;

namespace StoreBuild.Infra.Data.Repository.User
{
    public class UserRepository:IUserRepository
    {
        private StoreBuildDbContext _context;

        public UserRepository(StoreBuildDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Domain.Models.User.User> GetUsers()
        {
            return _context.Users
                .Include(u => u.SecurityAnswers)
                .Include(u => u.UserAddresses)
                .ThenInclude(ua => ua.City)
                .Include(u => u.UserDocuments)
                .Include(u => u.UserProfiles)
                .Include(u => u.UserSecurities);
        }
    }
}