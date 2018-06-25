using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SignalRCustomApp.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;

        static object locker = new object();

        public HomeController(IHostingEnvironment environment)
        {
            _hostingEnvironment = environment;
        }

       [HttpGet("GetAllMesssages")]
       public JsonResult GetAllMesssages()
        {
            var path = Path.Combine(_hostingEnvironment.ContentRootPath, "content\\messages.txt");

            var lines = System.IO.File.ReadAllLines(path);

            return Json(lines);
        }

    }
}