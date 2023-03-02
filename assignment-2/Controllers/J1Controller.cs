using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment_2.Controllers
{
    public class J1Controller : ApiController
    {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="burger"></param>
    /// <param name="drink"></param>
    /// <param name="side"></param>
    /// <param name="desert"></param>
    /// <returns></returns>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{desert}")]
        public string Menu(int burger, int drink, int side, int desert)
        {
            //to check the validity of the input
            if (burger <=4 && drink<=4 && side<=4 && desert<=4)
            {
                string message = ""; // to store the output
                List<int> burgers = new List<int>()
            {461,431,420,0 }; 
                List<int> drinks = new List<int>()
            {130,160,118,0 };
                List<int> sides = new List<int>()
            {100,57,70,0 };
                List<int> deserts = new List<int>()
            {167,266,75,0 };
                message = "Your total calorie count is " + (burgers[burger - 1] + drinks[drink - 1] +
                    sides[side - 1] + deserts[desert - 1]);
                return message;// returning the message
            }
            else
            {
                string invalid = "Selected order is out pf range.Please select from given menu";
                return invalid; // to return the message for the invalid input
            }
        } 
    }

}
