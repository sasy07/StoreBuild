using System.Collections.Generic;

namespace StoreBuild.Application.Interfaces.User
{
    public interface IUserService
    {
        List<Domain.Models.User.User> GetAllUsers();
        Domain.Models.User.User GetUserByMobile(string mobile);
        bool IsExistMobile(string mobile);
    }
}