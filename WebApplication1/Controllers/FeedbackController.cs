using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: Feedback
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult reg(Feedback model)
        {
            var result = new List<string> { };
            try
            {
                Database1Entities1 db = new Database1Entities1();
                db.Feedbacks.Add(model);
                db.SaveChanges();
                result.Add("Your feedbach has been submitted, thanks for your comment.");
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
