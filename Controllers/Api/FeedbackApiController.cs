using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleProject.Models;

namespace SampleProject.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackApiController : ControllerBase
    {

        [Route("GetData")]
        public IActionResult GetData()
        {
            Feedback ob = new Feedback();
            ob.Email = "Vishnu@gmail.com";
            ob.Message = "Hello";
           
            return Ok(ob);
        }
    }
}