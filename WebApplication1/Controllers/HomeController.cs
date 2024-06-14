using Domain;
using Domain.Response.Home;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;
using WebApplication1.Common;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        public IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet]
        [Route(RouteCommon.ROUTE_TESTING)]
        public  IActionResult testingAPI([FromQuery] RequestTesting request)
        {
            try
            {
                ResponseTesting result = _homeService.testingAPI(request).Result;
                return Ok(result);  
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
            
        }
    }
}
