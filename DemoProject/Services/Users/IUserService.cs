using DemoProject.Models;

namespace DemoProject.Services.Users;

public interface IUserService
{
    #region Users

    Task<IEnumerable<UserModel>> GetAllUsers();

    Task<UserModel> GetUserById(int id);

    Task<UserModel> CreateUser(UserModel userModel);

    Task<UserModel> UpdateUser(UserModel userModel);

    Task DeleteUser(UserModel userModel);

    #endregion

    #region User Descriptions

    Task<IEnumerable<UserDescriptionModel>> GetAllUserDescriptions();

    Task<UserDescriptionModel> GetUserDescriptionById(int id);

    Task<UserDescriptionModel> CreateUserDescription(UserDescriptionModel userDescriptionModel);

    Task<UserDescriptionModel> UpdateUserDescription(UserDescriptionModel userDescriptionModel);

    Task DeleteUserDescription(UserDescriptionModel userDescriptionModel);

    #endregion
}