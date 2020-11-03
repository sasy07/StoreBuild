using StoreBuild.Domain.Interfaces.User;

namespace StoreBuild.Infra.Data.Repository.User
{
    public class SecurityQuestionRepository:ISecurityQuestionRepository
    {
        private StoreBuildDbContext _context;

        public SecurityQuestionRepository(StoreBuildDbContext context)
        {
            _context = context;
        }
    }
}