using Domain;
using Domain.Response.Home;

namespace Service.Interface
{
    public interface IHomeService
    {
        Task<ResponseTesting> testingAPI(RequestTesting request);
    }
}
