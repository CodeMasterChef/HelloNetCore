using System;
using Microsoft.AspNetCore.Mvc;

namespace HelloNetCore.Controllers
{
    [Route("/")]
    public class HelloController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Hello World!";
        }

    }
}
