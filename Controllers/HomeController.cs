using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleProject.Models;

namespace SampleProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext dbContext;
        public HomeController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;

        }
        public IActionResult Index()
        {
            
            
            return View();
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Register newregister)
        {
            // AppDbContext dbContext = new AppDbContext();
            newregister.StudentId = Guid.NewGuid().ToString();
            dbContext.Registers.Add(newregister);
            dbContext.SaveChanges();


            return View(newregister);
        }


        [HttpGet]
        public IActionResult Feedback()
        {
            return View();
        }


    }
}