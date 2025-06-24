using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CitiesManager.API.Controllers
{
    public class TestController :CustomControllerBase
    {
        [HttpGet]
        public string Method()
        {
            return "Hello Word";
        }
    }
}
