using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestCompany1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return RedirectToAction("ListAllCustomers", "Customer");
            //return View();
        }
        public ActionResult CustomerNumber(string id)
        {
            ViewBag.Message = HttpUtility.HtmlEncode("Your temporary customer number is: " + id);
            return View();
        }

        public string Company(string name)
        {
            return HttpUtility.HtmlEncode("your company name is " + name);
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