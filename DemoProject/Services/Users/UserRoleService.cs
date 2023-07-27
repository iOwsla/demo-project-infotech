using AutoMapper;
using DemoProject.Data;
using DemoProject.Data.Entities;
using DemoProject.Models;

namespace DemoProject.Services.Users;

public class UserRoleService : IUserRoleService
{
    private readonly IRepository<UserRole> _repository;
    private readonly IMapper _mapper;

    public UserRoleService(IRepository<UserRole> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<UserRoleModel>> GetAllUserRoles()
    {
        var roles = await _repository.GetAll();

        var roleModels = _mapper.Map<IEnumerable<UserRoleModel>>(roles);

        return roleModels;
    }

    public async Task<UserRoleModel> GetUserRoleById(int id)
    {
        var role = await _repository.GetById(id);

        var roleModel = _mapper.Map<UserRoleModel>(role);

        return roleModel;
    }

    public async Task<UserRoleModel> CreateUserRole(UserRoleModel userRoleModel)
    {
        var role = _mapper.Map<UserRole>(userRoleModel);

        role = await _repository.Create(role);

        userRoleModel = _mapper.Map<UserRoleModel>(role);

        return userRoleModel;
    }

    public async Task<UserRoleModel> UpdateUserRole(UserRoleModel userRoleModel)
    {
        var role = _mapper.Map<UserRole>(userRoleModel);

        role = await _repository.Update(role);

        userRoleModel = _mapper.Map<UserRoleModel>(role);

        return userRoleModel;
    }

    public async Task DeleteUserRole(UserRoleModel userRoleModel)
    {
        var role = _mapper.Map<UserRole>(userRoleModel);

        await _repository.Delete(role);
    }
}