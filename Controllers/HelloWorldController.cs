using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        //
        public IActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["mensagem"] = "Hello " + name;
            ViewData["numTimes"] = numTimes;

            return View();
        }
    }
}