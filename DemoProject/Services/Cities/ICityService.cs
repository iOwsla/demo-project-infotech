using DemoProject.Models;

namespace DemoProject.Services.Cities;

public interface ICityService
{
    Task<IEnumerable<CityModel>> GetAllCities();

    Task<CityModel> GetCityById(int id);

    Task<CityModel> CreateCity(CityModel cityModel);

    Task<CityModel> UpdateCity(CityModel cityModel);

    Task DeleteCity(CityModel cityModel);
}