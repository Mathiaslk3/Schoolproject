using Microsoft.AspNetCore.Mvc;

namespace TestWebsite.Controllers
{
    public class LoginController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        [Route("/Account/Login")]
        public IActionResult Post()
        {
            return new ContentResult { 
                
            };
        }
    }
}
