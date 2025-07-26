using Microsoft.AspNetCore.Mvc;
using ViewsExample.Models;

namespace ViewsExample.Controllers
{
    [Route("home")]
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.appTittle = "Asp.NET Core Demo App";

        var people = new List<Person>()
            {
                new Person(){PersonName = "Emran", PersonGender = Gender.Male, DateOfBirth =DateTime.Parse("2002-02-22")},
                new Person(){PersonName = "Rakib", PersonGender = Gender.Male, DateOfBirth =DateTime.Parse("2000-02-22")},
                new Person(){PersonName = "Fairuz", PersonGender = Gender.Female, DateOfBirth =DateTime.Parse("2000-02-22")},
            };
            return View("Index",people);
        }
    }
}
