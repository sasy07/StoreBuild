using StoreBuild.Domain.Interfaces.User;

namespace StoreBuild.Infra.Data.Repository.User
{
    public class SecurityAnswerRepository:ISecurityAnswerRepository
    {
        private StoreBuildDbContext _context;

        public SecurityAnswerRepository(StoreBuildDbContext context)
        {
            _context = context;
        }
    }
}