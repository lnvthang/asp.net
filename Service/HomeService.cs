using Domain;
using Domain.Response.Home;
using Service.Interface;
using Util;

namespace Service
{
    public class HomeService : IHomeService
    {
        public static Utils _util = new Utils();
        public async Task<ResponseTesting> testingAPI(RequestTesting request)
        {
            if (!_util.checkRequest(request.Text) || !_util.checkRequest(request.Number))
            {
                throw new Exception();
            }
            var result = new ResponseTesting
            {
                Id = 1,
                Name = "Test",
                Status = true,
            };
            return result;
        }
    }
}
