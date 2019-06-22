using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PaperStore.Controllers
{
    [Route("health")]
    public class HealthController : Controller
    {
        [HttpGet("check")]
        string HealthCheck()
        {
            return "ok :)";
        }
    }
}