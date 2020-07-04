using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleProject.IRepository;
using SampleProject.Models;
using SampleProject.Repository;

namespace SampleProject.Controllers
{
    public class HomeController : Controller
    {


      //  private readonly IEmailSendingRepository emailRepository;
      
        
        private readonly AppDbContext dbContext;
        public HomeController (AppDbContext dbContext
            /*, IEmailSendingRepository emailRepository*/)
        {
            this.dbContext = dbContext;
            //  emailRepository = new EmailSendingRepository();// we are using new keyword
           
            
            //this.emailRepository = emailRepository;


        }
        public IActionResult Index()
        {
            
            //emailRepository.SendEmail();


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
        public IActionResult StudentList()
        {
            var resultList = dbContext.Registers.ToList();
            return View(resultList);
        }
        public IActionResult StudentL2()
        {
           
            
            var resultList = dbContext.Registers.ToList();
            return View(resultList);
        }


    }
}