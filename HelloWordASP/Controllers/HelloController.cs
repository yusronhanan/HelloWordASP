using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWordASP.Controllers
{
    public class HelloController : Controller
    {
        //
        // GET: /Hello/

        public ActionResult HelloWorld()
        {
            return View();
        }

    }
}
