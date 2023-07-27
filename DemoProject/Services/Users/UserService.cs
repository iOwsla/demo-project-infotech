using AutoMapper;
using DemoProject.Data;
using DemoProject.Models;
using DemoProject.Data.Entities;

namespace DemoProject.Services.Users;

public class UserService : IUserService
{
    private readonly IRepository<User> _repository;
    private readonly IRepository<UserDescription> _userDescriptionRepository;

    private readonly IMapper _mapper;

    public UserService(IRepository<User> repository, IRepository<UserDescription> userDescriptionRepository, IMapper mapper)
    {
        _repository = repository;
        _userDescriptionRepository = userDescriptionRepository;
        _mapper = mapper;
    }

    #region Users

    public async Task<IEnumerable<UserModel>> GetAllUsers()
    {
        var users = await _repository.GetAll();

        var userModels = _mapper.Map<IEnumerable<UserModel>>(users);

        return userModels;
    }

    public async Task<UserModel> GetUserById(int id)
    {
        var user = await _repository.GetById(id);

        var userModel = _mapper.Map<UserModel>(user);

        return userModel;
    }

    public async Task<UserModel> CreateUser(UserModel userModel)
    {
        var user = _mapper.Map<User>(userModel);

        user = await _repository.Create(user);

        userModel = _mapper.Map<UserModel>(user);

        return userModel;
    }

    public async Task<UserModel> UpdateUser(UserModel userModel)
    {
        var user = _mapper.Map<User>(userModel);

        user = await _repository.Update(user);

        userModel = _mapper.Map<UserModel>(user);

        return userModel;
    }

    public async Task DeleteUser(UserModel userModel)
    {
        var user = _mapper.Map<User>(userModel);

        await _repository.Delete(user);
    }

    #endregion

    #region User Descriptions

    public async Task<IEnumerable<UserDescriptionModel>> GetAllUserDescriptions()
    {
        var descriptions = await _userDescriptionRepository.GetAll();

        var descriptionModels = _mapper.Map<IEnumerable<UserDescriptionModel>>(descriptions);

        return descriptionModels;
    }

    public async Task<UserDescriptionModel> GetUserDescriptionById(int id)
    {
        var description = await _userDescriptionRepository.GetById(id);

        var descriptionModel = _mapper.Map<UserDescriptionModel>(description);

        return descriptionModel;
    }

    public async Task<UserDescriptionModel> CreateUserDescription(UserDescriptionModel userDescriptionModel)
    {
        var description = _mapper.Map<UserDescription>(userDescriptionModel);

        description = await _userDescriptionRepository.Create(description);

        userDescriptionModel = _mapper.Map<UserDescriptionModel>(description);

        return userDescriptionModel;
    }

    public async Task<UserDescriptionModel> UpdateUserDescription(UserDescriptionModel userDescriptionModel)
    {
        var description = _mapper.Map<UserDescription>(userDescriptionModel);

        description = await _userDescriptionRepository.Update(description);

        userDescriptionModel = _mapper.Map<UserDescriptionModel>(description);

        return userDescriptionModel;
    }

    public async Task DeleteUserDescription(UserDescriptionModel userDescriptionModel)
    {
        var description = _mapper.Map<UserDescription>(userDescriptionModel);

        await _userDescriptionRepository.Delete(description);
    }

    #endregion
}