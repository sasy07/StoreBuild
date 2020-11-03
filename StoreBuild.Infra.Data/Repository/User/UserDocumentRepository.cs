using StoreBuild.Domain.Interfaces.User;

namespace StoreBuild.Infra.Data.Repository.User
{
    public class UserDocumentRepository:IUserDocumentRepository
    {
        private StoreBuildDbContext _context;

        public UserDocumentRepository(StoreBuildDbContext context)
        {
            _context = context;
        }
    }
}