using Microsoft.AspNetCore.Mvc;

namespace CitiesManager.API.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class CustomControllerBase : ControllerBase
    {
    }
}