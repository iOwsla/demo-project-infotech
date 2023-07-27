using AutoMapper;
using DemoProject.Data;
using DemoProject.Data.Entities;
using DemoProject.Models;

namespace DemoProject.Services.Districts;

public class DistrictService : IDistrictService
{
    private readonly IRepository<District> _repository;
    private readonly IMapper _mapper;

    public DistrictService(IRepository<District> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<DistrictModel>> GetAllDistricts()
    {
        var districts = await _repository.GetAll();

        var districtModels = _mapper.Map<IEnumerable<DistrictModel>>(districts);

        return districtModels;
    }

    public async Task<DistrictModel> GetDistrictById(int id)
    {
        var district = await _repository.GetById(id);

        var districtModel = _mapper.Map<DistrictModel>(district);

        return districtModel;
    }

    public async Task<DistrictModel> CreateDistrict(DistrictModel districtModel)
    {
        var district = _mapper.Map<District>(districtModel);

        district = await _repository.Create(district);

        districtModel = _mapper.Map<DistrictModel>(district);

        return districtModel;
    }

    public async Task<DistrictModel> UpdateDistrict(DistrictModel districtModel)
    {
        var district = _mapper.Map<District>(districtModel);

        district = await _repository.Update(district);

        districtModel = _mapper.Map<DistrictModel>(district);

        return districtModel;
    }

    public async Task DeleteDistrict(DistrictModel districtModel)
    {
        var district = _mapper.Map<District>(districtModel);

        await _repository.Delete(district);
    }
}