using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class deleteController : Controller
    {
        // GET: delete
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult del3(string jobtitle, int forid)
        {

            Database1Entities1 ent = new Database1Entities1();
            var result = ent.JOBs.Where(x => x.jobtitle == jobtitle && x.forid == forid).ToList();
            foreach (var i in result)
            {
                ent.JOBs.Remove(i);
            }
            ent.SaveChanges();

            return View();
        }





    }

}