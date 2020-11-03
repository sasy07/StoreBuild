using System.Collections;
using System.Collections.Generic;

namespace StoreBuild.Domain.Interfaces.User
{
    public interface IUserRepository
    {
        public IEnumerable<Models.User.User> GetUsers();
    }
}