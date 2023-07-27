using AutoMapper;
using DemoProject.Data;
using DemoProject.Data.Entities;
using DemoProject.Models;

namespace DemoProject.Services.Services;

public class ServiceCategoryService : IServiceCategoryService
{
    private readonly IRepository<ServiceCategory> _repository;
    private readonly IMapper _mapper;

    public ServiceCategoryService(IRepository<ServiceCategory> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ServiceCategoryModel>> GetAllServiceCategories()
    {
        var categories = await _repository.GetAll();

        var categoryModels = _mapper.Map<IEnumerable<ServiceCategoryModel>>(categories);

        return categoryModels;
    }

    public async Task<ServiceCategoryModel> GetServiceCategoryById(int id)
    {
        var category = await _repository.GetById(id);

        var categoryModel = _mapper.Map<ServiceCategoryModel>(category);

        return categoryModel;
    }

    public async Task<ServiceCategoryModel> CreateServiceCategory(ServiceCategoryModel serviceCategoryModel)
    {
        var category = _mapper.Map<ServiceCategory>(serviceCategoryModel);

        category = await _repository.Create(category);

        serviceCategoryModel = _mapper.Map<ServiceCategoryModel>(category);

        return serviceCategoryModel;
    }

    public async Task<ServiceCategoryModel> UpdateServiceCategory(ServiceCategoryModel serviceCategoryModel)
    {
        var category = _mapper.Map<ServiceCategory>(serviceCategoryModel);

        category = await _repository.Update(category);

        serviceCategoryModel = _mapper.Map<ServiceCategoryModel>(category);

        return serviceCategoryModel;
    }

    public async Task DeleteServiceCategory(ServiceCategoryModel serviceCategoryModel)
    {
        var category = _mapper.Map<ServiceCategory>(serviceCategoryModel);

        await _repository.Delete(category);
    }
}