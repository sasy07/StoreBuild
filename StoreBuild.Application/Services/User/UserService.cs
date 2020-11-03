using System.Collections.Generic;
using System.Linq;
using StoreBuild.Application.Interfaces.User;
using StoreBuild.Domain.Interfaces.User;

namespace StoreBuild.Application.Services.User
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private IUserSecurityService _userSecurityService;

        public UserService(IUserRepository userRepository, IUserSecurityService userSecurityService)
        {
            _userRepository = userRepository;
            _userSecurityService = userSecurityService;
        }

        public List<Domain.Models.User.User> GetAllUsers()
        {
            return _userRepository.GetUsers().ToList();
        }

        public Domain.Models.User.User GetUserByMobile(string mobile)
        {
            return _userRepository.GetUsers().SingleOrDefault(u => u.Mobile == mobile);
        }

        public bool IsExistMobile(string mobile)
        {
            var userSecurity = _userSecurityService.GetUserSecurityByMobile(mobile);
            if (GetAllUsers().Any(u => u.Mobile == mobile && userSecurity.MobileConfirmation))
            {
                return true;
            }

            return false;
        }
    }
}