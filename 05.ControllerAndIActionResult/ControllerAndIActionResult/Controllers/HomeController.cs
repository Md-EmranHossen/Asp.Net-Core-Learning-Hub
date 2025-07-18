using Microsoft.AspNetCore.Mvc;


namespace ControllerAndIActionResult.Controllers
{
   public class HomeController : Controller
    {
        [Route("home")]
        [Route("/")]
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


    }
}
