using DemoProject.Models;

namespace DemoProject.Services.Users;

public interface IUserRoleService
{
    Task<IEnumerable<UserRoleModel>> GetAllUserRoles();

    Task<UserRoleModel> GetUserRoleById(int id);

    Task<UserRoleModel> CreateUserRole(UserRoleModel userRoleModel);

    Task<UserRoleModel> UpdateUserRole(UserRoleModel userRoleModel);

    Task DeleteUserRole(UserRoleModel userRoleModel);
}