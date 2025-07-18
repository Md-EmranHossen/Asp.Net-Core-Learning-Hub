using Microsoft.AspNetCore.Mvc;

namespace IActionResultExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Book id should be applied
            if (!Request.Query.ContainsKey("bookid"))
            {
                return BadRequest("Book is not supplied");
            }

            // Book id cna't be empty
            if (string.IsNullOrEmpty(Convert.ToString(Request.Query["bookid"]))){
                return BadRequest("Book id can't be null or empty");
            }


            // Book is should be between 1 to 100
            int bookId = Convert.ToUInt16(ControllerContext.HttpContext.Request.Query["Bookid"]);

            if(bookId <= 0)
            {
                return BadRequest("Book id can not be less then zero");
            }

            if(bookId > 1000)
            {
                return NotFound("Book id can't not be greater than 1000");
            }

            // isloggedin should be true
            if(Convert.ToBoolean(Request.Query
                ["isloggedin"]) == false)
            {

                //   return Unauthorized("User must be authenticated");
                return StatusCode(401);
            }

            return File("/FirstMonth.pdf","application/pdf");
        }
    }
}
