using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AwaitAsyncDeepDive.Controllers
{
    public class DoesntMatterWhichThread : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<string> InputOutput()
        {
            var client = new HttpClient();
            var content = await client.GetStringAsync("some title").ConfigureAwait(false);
           
            return content;
        }
    }
}
