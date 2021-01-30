using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

using BlazorApp.Shared;

namespace BlazorApp.Api
{
    public static class RandomNumberFunction
    {

        [FunctionName("MyRandom")]
        public static IActionResult RunRandom(
          [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
          ILogger log)
        {
            var randomNumber = new Random();           

            return new OkObjectResult(randomNumber);
        }
    }
}
