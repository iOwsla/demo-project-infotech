using AutoMapper;
using DemoProject.Data.Entities;
using DemoProject.Models;

namespace DemoProject.Infrastructure;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserModel>();

        CreateMap<UserModel, User>();

        CreateMap<UserRole, UserRoleModel>();

        CreateMap<UserRoleModel, UserRole>();

        CreateMap<UserDescription, UserDescriptionModel>();

        CreateMap<UserDescriptionModel, UserDescription>();

        CreateMap<City, CityModel>();

        CreateMap<CityModel, City>();

        CreateMap<District, DistrictModel>();

        CreateMap<DistrictModel, District>();

        CreateMap<Service, ServiceModel>();

        CreateMap<ServiceModel, Service>();

        CreateMap<ServiceCategory, ServiceCategoryModel>();

        CreateMap<ServiceCategoryModel, ServiceCategory>();

        CreateMap<Request, RequestModel>();

        CreateMap<RequestModel, Request>();
    }
}