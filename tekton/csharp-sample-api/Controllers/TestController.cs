using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_sample_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {

        private readonly ILogger<TestController> _logger;
        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/")]
        public string Get1()
        {
            var v = Environment.GetEnvironmentVariable("Version");
            if (string.IsNullOrEmpty(v))
            {
                v = "1";
            }
            return $"1-hello knative {v}!";
        }
        [HttpGet]
        public string Get2()
        {
            var v = Environment.GetEnvironmentVariable("Version");
            if (string.IsNullOrEmpty(v))
            {
                v = "1";
            }
            return $"2-hello knative {v}!";
        }
    }
}
