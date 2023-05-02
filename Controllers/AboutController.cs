using Microsoft.AspNetCore.Mvc;

namespace RoadSafetyTool.Controllers
{
    public class AboutController : Controller
    {

        private IConfiguration Configuration;
        public AboutController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}


