using System.Collections.Generic;
using System.Linq;
using StoreBuild.Application.Interfaces.User;
using StoreBuild.Domain.Interfaces.User;
using StoreBuild.Domain.Models.User;

namespace StoreBuild.Application.Services.User
{
    public class UserSecurityService:IUserSecurityService
    {
        private IUserSecurityRepository _userSecurityRepository;

        public UserSecurityService(IUserSecurityRepository userSecurityRepository)
        {
            _userSecurityRepository = userSecurityRepository;
        }

        public List<UserSecurity> GetAllUserSecurities()
        {
            return _userSecurityRepository.GetUserSecurities().ToList();
        }

        public UserSecurity GetUserSecurityByMobile(string mobile)
        {
            return GetAllUserSecurities().SingleOrDefault(us => us.User.Mobile == mobile);
        }
    }
}