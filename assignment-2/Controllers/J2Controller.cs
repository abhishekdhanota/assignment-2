using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Web.Caching;
using System.Web.Http;

namespace assignment_2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        // GET: /api/J2/DiceGame/{a}/{b}
        [HttpGet]
        [Route("api/J2/DiceGame/{a}/{b}")]
        public string DiceGame(int a, int b)
        {
            int count = 0;
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= b; j++)
                {
                    if (i + j == 10)
                    {
                        count++;
                    
                    }
                }
            }

            string output = "There are " + count + "total ways to get the sum 10.";
            return output;
        }
    }
}
