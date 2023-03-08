using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace assignment_2.Controllers
{
    public class J3Controller : ApiController
    {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
        [HttpGet]
        [Route("api/J3/mobile/{input}")]
        public string mobile(string input)
        {
            int count = 0;
            string output = "";
            string first = "adgjmptw";
            string second = "behknqux";
            string third = "cfilorvy";
            string fourth = "sz";
            
            for (int i =1; i <= (input.Length)+1; i++)
            {
                if (first.Contains(input.Substring(i,i)))
                {
                    count=count+1;
                    break;
                }
                else if (second.Contains(input.Substring(i,i)))
                {
                   count=count+2;
                    break;
                }
                else if (third.Contains(input.Substring(i,i)))
                {
                  count=count+3;
                    break;
                }
                else if (fourth.Contains(input.Substring(i, i)))
                {
                  count=count+4;
                    break;
                }
                else
                {
                count = count+0;
                   break;
                }
            }
            output = "total keys presses" + count;
            return output;
        }
    }
}
