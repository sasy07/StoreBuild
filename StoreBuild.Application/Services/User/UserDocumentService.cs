using StoreBuild.Application.Interfaces.User;
using StoreBuild.Domain.Interfaces.User;

namespace StoreBuild.Application.Services.User
{
    public class UserDocumentService:IUserDocumentService
    {
        private IUserDocumentRepository _userDocumentRepository;

        public UserDocumentService(IUserDocumentRepository userDocumentRepository)
        {
            _userDocumentRepository = userDocumentRepository;
        }
    }
}