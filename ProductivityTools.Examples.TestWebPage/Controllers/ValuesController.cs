using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProductivityTools.Examples.TestWebPage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DateController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return DateTime.Now.ToString();
        }
    }
}
