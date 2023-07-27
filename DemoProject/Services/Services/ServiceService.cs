using AutoMapper;
using DemoProject.Data;
using DemoProject.Data.Entities;
using DemoProject.Models;

namespace DemoProject.Services.Services;

public class ServiceService : IServiceService
{
    private readonly IRepository<Service> _repository;
    private readonly IMapper _mapper;

    public ServiceService(IRepository<Service> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ServiceModel>> GetAllServices()
    {
        var services = await _repository.GetAll();

        var serviceModels = _mapper.Map<IEnumerable<ServiceModel>>(services);

        return serviceModels;
    }

    public async Task<ServiceModel> GetServiceById(int id)
    {
        var service = await _repository.GetById(id);

        var serviceModel = _mapper.Map<ServiceModel>(service);

        return serviceModel;
    }

    public async Task<ServiceModel> CreateService(ServiceModel serviceModel)
    {
        var service = _mapper.Map<Service>(serviceModel);

        service = await _repository.Create(service);

        serviceModel = _mapper.Map<ServiceModel>(service);

        return serviceModel;
    }

    public async Task<ServiceModel> UpdateService(ServiceModel serviceModel)
    {
        var service = _mapper.Map<Service>(serviceModel);

        service = await _repository.Update(service);

        serviceModel = _mapper.Map<ServiceModel>(service);

        return serviceModel;
    }

    public async Task DeleteService(ServiceModel serviceModel)
    {
        var service = _mapper.Map<Service>(serviceModel);

        await _repository.Delete(service);
    }
}