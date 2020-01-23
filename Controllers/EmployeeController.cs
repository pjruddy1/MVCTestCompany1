using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestCompany1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(string type)
        {
            string t = HttpUtility.HtmlEncode(type);
            if (t == "m")
            {
                ViewBag.Title = "Manager Index";
                return View("ManagerIndex");
            }
            else
            {
                return View();
            }
        }

        public ContentResult Search(string name)
        {
            var input = HttpUtility.HtmlEncode(name);
            return Content(input);
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

        public ActionResult NewEmployee()
        {

            return View("NewEmployeeForm");
        }

        [HttpPost]
        public ActionResult NewEmployee(string firstname, string lastName, string title)
        {
            ViewBag.Message = "Name: " + firstname + " " + lastName;
            ViewBag.Message += " Title: " + title;
            return View("ConfirmEmployee");
        }
    }
}