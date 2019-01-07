using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ContentResult Detail()
        {
            return new ContentResult()
            {
                Content = "This is my content in detail action method";
            };
        }
    }
}