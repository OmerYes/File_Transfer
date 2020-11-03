using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace File_Transfer.Controllers
{
    public class HomeController : Controller
    {
       [Route("")]
        [Route("Home/upload")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
     [Route("Home/test")]
        public IActionResult test(IFormCollection formCollection)
        {
            long size = 0;
            var files = Request.Form.Files;
            return View();
        }
        [Route("home/file")]
        public IActionResult FileUpload()
        {
            return View();
        }
    }
}