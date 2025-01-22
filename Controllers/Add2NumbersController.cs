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
    public class Add2NumbersController : ControllerBase
    {
        private readonly Add2NumbersServices _add2NumbersServices;

        public Add2NumbersController(Add2NumbersServices add2NumbersServices){
            _add2NumbersServices = add2NumbersServices;
        }

        [HttpGet]
        [Route("Add/{num1}/{num2}")]

        public string addTwo(string num1, string num2){
            return _add2NumbersServices.addTwo(num1, num2);
        }
    }
}