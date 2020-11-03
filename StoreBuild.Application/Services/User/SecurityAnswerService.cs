using StoreBuild.Application.Interfaces.User;
using StoreBuild.Domain.Interfaces.User;

namespace StoreBuild.Application.Services.User
{
    public class SecurityAnswerService:ISecurityAnswerService
    {
        private ISecurityAnswerRepository _securityAnswerRepository;

        public SecurityAnswerService(ISecurityAnswerRepository securityAnswerRepository)
        {
            _securityAnswerRepository = securityAnswerRepository;
        }
    }
}