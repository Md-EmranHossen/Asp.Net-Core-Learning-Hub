using IActionResultExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace IActionResultExample.Controllers
{
  public class HomeController : Controller
  {
    [Route("bookstore/{bookId?}/{isloggedin?}/{bookName?}")]
    //Url: /bookstore?bookid=10&isloggedin=true
    public IActionResult Index( int? bookId,[FromRoute] bool? isloggedin,Book book)
    {
      
      if (bookId == null)
      {
        return BadRequest("Book id is not supplied or null");
      }

      //Book id should be between 1 to 1000
      if (bookId <= 0)
      {
        return BadRequest("Book id can't be less than or equal to zero");
      }
      if (bookId > 1000)
      {
        return NotFound("Book id can't be greater than 1000");
      }

      //isloggedin should be true
      if (isloggedin == false)
      {
        //return Unauthorized("User must be authenticated");
        return StatusCode(401);
      }

      return Content($"Book id: {bookId}","text/plain");
    
    }
  }
}
