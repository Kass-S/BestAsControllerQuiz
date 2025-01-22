using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestAsControllerQuiz.models;

namespace BestAsControllerQuiz.Services
{
    public class SayHello2Services
    {
        public string SayHello2(SayHello2Model UserName){
        
            return $"Hi, {UserName}! It's nice to meet you!";
        }
    }
}