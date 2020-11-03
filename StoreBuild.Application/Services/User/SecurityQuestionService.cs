using StoreBuild.Application.Interfaces.User;
using StoreBuild.Domain.Interfaces.User;

namespace StoreBuild.Application.Services.User
{
    public class SecurityQuestionService:ISecurityQuestionService
    {
        private ISecurityQuestionRepository _securityQuestionRepository;

        public SecurityQuestionService(ISecurityQuestionRepository securityQuestionRepository)
        {
            _securityQuestionRepository = securityQuestionRepository;
        }
    }
}