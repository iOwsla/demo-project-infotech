using AutoMapper;
using DemoProject.Data;
using DemoProject.Data.Entities;
using DemoProject.Models;

namespace DemoProject.Services.Cities;

public class CityService : ICityService
{
    private readonly IRepository<City> _repository;
    private readonly IMapper _mapper;

    public CityService(IRepository<City> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CityModel>> GetAllCities()
    {
        var cities = await _repository.GetAll();

        var cityModels = _mapper.Map<IEnumerable<CityModel>>(cities);

        return cityModels;
    }

    public async Task<CityModel> GetCityById(int id)
    {
        var city = await _repository.GetById(id);

        var cityModel = _mapper.Map<CityModel>(city);

        return cityModel;
    }

    public async Task<CityModel> CreateCity(CityModel cityModel)
    {
        var city = _mapper.Map<City>(cityModel);

        city = await _repository.Create(city);

        cityModel = _mapper.Map<CityModel>(city);

        return cityModel;
    }

    public async Task<CityModel> UpdateCity(CityModel cityModel)
    {
        var city = _mapper.Map<City>(cityModel);

        city = await _repository.Update(city);

        cityModel = _mapper.Map<CityModel>(city);

        return cityModel;
    }

    public async Task DeleteCity(CityModel cityModel)
    {
        var city = _mapper.Map<City>(cityModel);

        await _repository.Delete(city);
    }
}