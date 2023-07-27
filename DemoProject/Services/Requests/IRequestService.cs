using DemoProject.Models;

namespace DemoProject.Services.Requests;

public interface IRequestService
{
    Task<IEnumerable<RequestModel>> GetAllRequests();

    Task<RequestModel> GetRequestById(int id);

    Task<RequestModel> CreateRequest(RequestModel requestModel);

    Task<RequestModel> UpdateRequest(RequestModel requestModel);

    Task DeleteRequest(RequestModel requestModel);
}