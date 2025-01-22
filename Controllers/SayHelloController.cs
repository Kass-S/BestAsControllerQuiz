using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestAsControllerQuiz.Services;
using Microsoft.AspNetCore.Mvc;

namespace BestAsControllerQuiz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        private readonly SayHelloServices _sayHelloServices;
        public SayHelloController(SayHelloServices sayHelloServices){
            _sayHelloServices = sayHelloServices;
        }

        [HttpGet]
        [Route("Greeting/{userName}")]
        public string SayHello(string userName){
            return _sayHelloServices.SayHello(userName);
        }
    }
}