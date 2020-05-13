using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace azure_function_sandbox
{
    public static class Hello
    {
        [FunctionName("Hello")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "{name}")] HttpRequest req,
            ILogger log)
        {
            return new OkObjectResult("Hello is called");
        }
    }
}
