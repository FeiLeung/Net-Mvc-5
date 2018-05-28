using SessionSample.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //登陆
        public ActionResult Login()
        {
            Session["auth"] = true;
            return RedirectToAction("Index");
        }

        //注销
        public ActionResult Logout()
        {
            Session["auth"] = false;
            return RedirectToAction("Index");
        }

        //后台
        [AuthorizePlus]
        public ActionResult Backend()
        {
            return Content("您已进入后台");
        }
    }
}