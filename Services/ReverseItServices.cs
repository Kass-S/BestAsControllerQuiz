using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestAsControllerQuiz.Services
{
    public class ReverseItServices
    {
        public string Reverse(string userInput){
            string reverse = "";
            for(int i = userInput.Length - 1 ; i >= 0; i--)
            {
                reverse += userInput[i];
            }
            return $"Your input was {userInput}, and its reverse is {reverse}";
        }
    }
}