using DemoProject.Models;

namespace DemoProject.Services.Districts;

public interface IDistrictService
{
    Task<IEnumerable<DistrictModel>> GetAllDistricts();

    Task<DistrictModel> GetDistrictById(int id);

    Task<DistrictModel> CreateDistrict(DistrictModel districtModel);

    Task<DistrictModel> UpdateDistrict(DistrictModel districtModel);

    Task DeleteDistrict(DistrictModel districtModel);
}