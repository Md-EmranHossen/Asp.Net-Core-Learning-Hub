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
                Response.StatusCode = 400;
                return Content("Book id is not supplied");
            }

            // Book id cna't be empty
            if (string.IsNullOrEmpty(Convert.ToString(Request.Query["bookid"]))){
                return Content("Book id can't be null or empty");
            }

            // Book is should be between 1 to 100
            int bookId = Convert.ToUInt16(ControllerContext.HttpContext.Request.Query["Bookid"]);

            if(bookId <= 0)
            {
                return Content("Book id can not be less then zero");
            }

            if(bookId > 1000)
            {
                return Content("Book id can't be greater than 1000");
            }

            // isloggedin should be true
            if(Convert.ToBoolean(Request.Query
                ["isloggedin"]) == false)
            {
                Response.StatusCode = 401;
                return Content("User must be authenticated");
            }

            return File("/FirstMonth.pdf","application/pdf");
        }
    }
}
