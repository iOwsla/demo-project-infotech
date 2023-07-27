using AutoMapper;
using DemoProject.Data;
using DemoProject.Data.Entities;
using DemoProject.Models;

namespace DemoProject.Services.Requests;

public class RequestService : IRequestService
{
    private readonly IRepository<Request> _repository;
    private readonly IMapper _mapper;

    public RequestService(IRepository<Request> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<RequestModel>> GetAllRequests()
    {
        var requests = await _repository.GetAll();

        var requestModels = _mapper.Map<IEnumerable<RequestModel>>(requests);

        return requestModels;
    }

    public async Task<RequestModel> GetRequestById(int id)
    {
        var request = await _repository.GetById(id);

        var requestModel = _mapper.Map<RequestModel>(request);

        return requestModel;
    }

    public async Task<RequestModel> CreateRequest(RequestModel requestModel)
    {
        var request = _mapper.Map<Request>(requestModel);

        request = await _repository.Create(request);

        requestModel = _mapper.Map<RequestModel>(request);

        return requestModel;
    }

    public async Task<RequestModel> UpdateRequest(RequestModel requestModel)
    {
        var request = _mapper.Map<Request>(requestModel);

        request = await _repository.Update(request);

        requestModel = _mapper.Map<RequestModel>(request);

        return requestModel;
    }

    public async Task DeleteRequest(RequestModel requestModel)
    {
        var request = _mapper.Map<Request>(requestModel);

        await _repository.Delete(request);
    }
}