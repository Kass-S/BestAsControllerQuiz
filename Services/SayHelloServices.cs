using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestAsControllerQuiz.Services
{
    public class SayHelloServices
    {
        public string SayHello(string UserName){
            return $"Hi, {UserName}! It's nice to meet you!";
        }
    }
}