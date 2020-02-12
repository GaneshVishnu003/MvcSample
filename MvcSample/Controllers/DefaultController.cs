using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSample.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult ShowHi()
        {
            return View();
        }
    }
}