using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestAsControllerQuiz.models;
using BestAsControllerQuiz.Services;
using Microsoft.AspNetCore.Mvc;

namespace BestAsControllerQuiz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHello2Controller : ControllerBase
    {
        private readonly SayHello2Services _sayHello2Services;
        public SayHello2Controller(SayHello2Services sayHello2Services){
            _sayHello2Services = sayHello2Services;
        }

        [HttpGet]
        [Route("Hello2/{userName}")]
        public string SayHello2(SayHello2Model userName){
            return _sayHello2Services.SayHello2(userName);
        }
    }
}