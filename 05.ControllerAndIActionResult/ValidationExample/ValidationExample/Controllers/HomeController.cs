using Microsoft.AspNetCore.Mvc;
using ValidationExample.Models;

namespace ValidationExample.Controllers
{
    public class HomeController : Controller
    {
        //[Bind(nameof(Person.Name),nameof(Person.Email),nameof(Person.Password),nameof(Person.ConfirmPassword))]
        [Route("Persondetails")]
        public IActionResult Index([FromBody] Person person)
        {
            if (!ModelState.IsValid)
            {
                string errors = string.Join("\n",
                ModelState.Values.SelectMany(value =>
                value.Errors).Select(err => err.ErrorMessage));

                return BadRequest(errors);
            }

            return Content($"{person}");
        }
    }
}
