using DemoProject.Models;

namespace DemoProject.Services.Services;

public interface IServiceService
{
    Task<IEnumerable<ServiceModel>> GetAllServices();

    Task<ServiceModel> GetServiceById(int id);

    Task<ServiceModel> CreateService(ServiceModel serviceModel);

    Task<ServiceModel> UpdateService(ServiceModel serviceModel);

    Task DeleteService(ServiceModel serviceModel);
}