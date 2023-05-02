using Microsoft.AspNetCore.Mvc;

namespace RoadSafetyTool.Controllers
{

    public class BikeController : Controller
    {
        private IConfiguration Configuration;
        public BikeController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }
        public IActionResult Index()
        {

            return View();
        }
    }
}
