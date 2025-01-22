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
    public class ReverseItController : ControllerBase
    {
        private readonly ReverseItServices _reverseItServices;
        public ReverseItController(ReverseItServices reverseItServices){
            _reverseItServices = reverseItServices;
        }

        [HttpGet]
        [Route("Reverse/{userInput}")]
        public string Reverse(string userInput){
            return _reverseItServices.Reverse(userInput);
        }
    }
}