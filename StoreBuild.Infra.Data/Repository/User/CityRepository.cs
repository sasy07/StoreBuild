using StoreBuild.Domain.Interfaces.User;
using StoreBuild.Domain.Models.User;

namespace StoreBuild.Infra.Data.Repository.User
{
    public class CityRepository:ICityRepository
    {
        private StoreBuildDbContext _context;

        public CityRepository(StoreBuildDbContext context)
        {
            _context = context;
        }
        
        public void AddCity(City city)
        {
            _context.Cities.Add(city);
        }
        
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}