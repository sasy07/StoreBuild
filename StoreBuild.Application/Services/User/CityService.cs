using StoreBuild.Application.Interfaces.User;
using StoreBuild.Domain.Interfaces.User;
using StoreBuild.Domain.Models.User;

namespace StoreBuild.Application.Services.User
{
    public class CityService:ICityService
    {
        private ICityRepository _cityRepository;

        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }
        
        public void AddCity(City city)
        {
            _cityRepository.AddCity(city);
            _cityRepository.Save();
        }
    }
}