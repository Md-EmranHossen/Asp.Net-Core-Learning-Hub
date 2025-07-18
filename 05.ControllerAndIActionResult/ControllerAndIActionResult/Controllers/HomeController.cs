using Microsoft.AspNetCore.Mvc;
using ControllerAndIActionResult.Models;

namespace ControllerAndIActionResult.Controllers
{
   public class HomeController : Controller
    {
        [Route("home")]
       
        public ContentResult Index()
        {
            /*
             return new ContentResult()
              {
                  Content = "Hello From Index",
                  ContentType = "text/plain"
              };
             */

            //  return Content("Hello from Index", "text/plain");

            return Content("<h1> Welcome </h1> <h2>Hello from Index</h2>","text/html");
        }
        [Route("/")]
        [Route("person")]
        public JsonResult Person()
        {
            Person person = new Person() { Id = Guid.NewGuid(), FirstName = "Emran", LastName = "Hossen", Age = 25 };
            // return new JsonResult(person);
            return Json(person);
        }

    }
}
