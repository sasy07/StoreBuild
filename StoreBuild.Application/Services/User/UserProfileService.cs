using StoreBuild.Application.Interfaces.User;
using StoreBuild.Domain.Interfaces.User;

namespace StoreBuild.Application.Services.User
{
    public class UserProfileService:IUserProfileService
    {
        private IUserProfileRepository _userProfileRepository;

        public UserProfileService(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }
    }
}