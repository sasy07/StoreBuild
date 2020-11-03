using StoreBuild.Domain.Models.User;

namespace StoreBuild.Domain.Interfaces.User
{
    public interface ICityRepository
    {
        void AddCity(City city);
        void Save();
    }
}