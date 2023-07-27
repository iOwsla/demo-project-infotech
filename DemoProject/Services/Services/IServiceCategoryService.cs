using DemoProject.Models;

namespace DemoProject.Services.Services;

public interface IServiceCategoryService
{
    Task<IEnumerable<ServiceCategoryModel>> GetAllServiceCategories();

    Task<ServiceCategoryModel> GetServiceCategoryById(int id);

    Task<ServiceCategoryModel> CreateServiceCategory(ServiceCategoryModel serviceCategoryModel);

    Task<ServiceCategoryModel> UpdateServiceCategory(ServiceCategoryModel serviceCategoryModel);

    Task DeleteServiceCategory(ServiceCategoryModel serviceCategoryModel);
}