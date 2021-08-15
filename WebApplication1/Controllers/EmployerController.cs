using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployerController : Controller
    {
        // GET: Employer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult reg1(Employer model)
        {
            var result = new List<string> { };
            try
            {
                Database1Entities1 db = new Database1Entities1();
                db.Employers.Add(model);
                db.SaveChanges();
                result.Add("Registration is successful!");
            }
            catch
            {
                result.Add( "invalid");
            }
            ViewBag.result = result;
            return View();
        }
    }
}



