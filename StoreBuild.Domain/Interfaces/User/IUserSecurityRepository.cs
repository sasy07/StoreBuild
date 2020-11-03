using System.Collections;
using System.Collections.Generic;
using StoreBuild.Domain.Models.User;

namespace StoreBuild.Domain.Interfaces.User
{
    public interface IUserSecurityRepository
    {
        IEnumerable<UserSecurity> GetUserSecurities();
    }
}