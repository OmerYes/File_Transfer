using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace File_Transfer.Controllers
{
    public class HomeController : Controller
    {
       
        [Route("Home/get-file")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("")]
        [Route("hey")]
        public IActionResult test()
        {
            return View();
        }
    }
}