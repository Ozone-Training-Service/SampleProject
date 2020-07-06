using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleProject.Controllers
{
    public class TestController : Controller
    {


        public IActionResult Index()
        {

            return View();
        }


        public IActionResult Index2()
        {

            return PartialView("PartialView1");
        }
    }
}