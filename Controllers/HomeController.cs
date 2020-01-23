using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestCompany1.Controllers
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

        public string ListAllCustomers()
        {
            return @"<ul>
                    <li>Fred Lisnstone</li>
                    <li>PJ Ruddy</li>
                    <li>Billy Jean</li>
                    <li>Bobby Joe</li>
                    </ul>";
        }
    }
}