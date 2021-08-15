using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class JobController : Controller
    {
        // GET: Job
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult reg1(JOB model)
        {
            var result = new List<string> { };
            try
            {
                Database1Entities1 db = new Database1Entities1();
                db.JOBs.Add(model);
                db.SaveChanges();
                result.Add ("This job was successfully added!");
            }
            catch
            {
                result.Add("invalid");
            }
            ViewBag.result = result;
            return View();
        }
    }
}


