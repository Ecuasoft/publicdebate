using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PublicDebate.Web.Controllers
{
    [Route("api/[controller]")]
    public class DebateController : Controller
    {
        [HttpPost]
        public void Post([FromBody] CreateDebateApiModel createDebateApiModel)
        {
            
        }
    }

}
