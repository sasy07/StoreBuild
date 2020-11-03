using System.Collections.Generic;
using StoreBuild.Domain.Models.User;

namespace StoreBuild.Application.Interfaces.User
{
    public interface IUserSecurityService
    {
        List<UserSecurity> GetAllUserSecurities();
        UserSecurity GetUserSecurityByMobile(string mobile);
    }
}