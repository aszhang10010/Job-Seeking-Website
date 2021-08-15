using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult se(string jobtitle)
        {
            Database1Entities1 db = new Database1Entities1();
            List<JOB> s = db.JOBs.Where(x => x.jobtitle == jobtitle).ToList();
           
            return View(s);
        }
        public ActionResult se1(string location)
        {
            Database1Entities1 db = new Database1Entities1();
    
            List<JOB> s = db.JOBs.Where(x => x.location == location).ToList();
            return View(s);
        }



    }
}