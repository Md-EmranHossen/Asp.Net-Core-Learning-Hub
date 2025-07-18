using Microsoft.AspNetCore.Mvc;
using ControllerAndIActionResult.Models;

namespace ControllerAndIActionResult.Controllers
{
    public class HomeController : Controller
    {
        [Route("file-download")]
        public VirtualFileResult FileDownload()
        {
           // return new VirtualFileResult("/FirstMonth.pdf","application/pdf");
            return File("/FirstMonth.pdf", "application/pdf");
        }



        [Route("file-download2")]
        public PhysicalFileResult FileDownload2()
        {
            //return new PhysicalFileResult(@"c:\aspnetcore\FirstMonth.pdf", "application/pdf");
            return  PhysicalFile(@"c:\aspnetcore\FirstMonth.pdf", "application/pdf");

        }



        [Route("file-download3")]
        public FileContentResult FileDownload3()
        {
          byte[] bytes =  System.IO.File.ReadAllBytes(@"c:\aspnetcore\FirstMonth.pdf");
            // return new FileContentResult(bytes, "application/pdf");
            return File(bytes, "application/pdf");
        }
    }
} 
