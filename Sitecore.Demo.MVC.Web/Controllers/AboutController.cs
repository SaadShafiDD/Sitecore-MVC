using Sitecore.Demo.MVC.Web.Models;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sitecore.Demo.MVC.Web.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            var model = new AboutVM() 
            { 
                Item = RenderingContext.Current?.Rendering.Item
            };
            return View(model);
        }
    }
}