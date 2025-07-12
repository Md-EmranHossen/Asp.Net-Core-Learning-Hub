using Microsoft.AspNetCore.Mvc;

namespace ControllerAndIActionResult.Controllers
{
   public class HomeController : Controller
    {
        [Route("sayhello")]
        public string methood1()
        {
            return "Hello From method1";
        }
    }
}
