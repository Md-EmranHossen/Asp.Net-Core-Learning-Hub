using Microsoft.AspNetCore.Mvc;

namespace ControllerAndIActionResult.Controllers
{
   public class HomeController : Controller
    {
        [Route("home")]
        [Route("/")]
        public string Index()
        {
            return "Hello From Home";
        }

        [Route("about")]
        public string About()
        {
            return "Hello From About";   
        }

        [Route("contact-us/{mobile:ragex(^\\d{{10}}$)}")]
        public string Contact()
        {
            return "Hello From Contact";
        }
    }
}
