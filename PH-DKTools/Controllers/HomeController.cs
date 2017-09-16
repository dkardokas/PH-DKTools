using PH_DKTools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PH_DKTools.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Errors()
        {
            var errors = new List<ErrorModel>();
            errors.Add(new ErrorModel(12, "Object Null Refrenece", "Critical", "Your code sucks!", DateTime.Now));
            errors.Add(new ErrorModel(17, "Ovewrflow", "Critical", "Your code sucks!", DateTime.Now.AddHours(1)));
            errors.Add(new ErrorModel(19, "Out Of Memory", "Unexpected", "Your code sucks!", DateTime.Now.AddMilliseconds(-3)));
            errors.Add(new ErrorModel(122, "Generic Failure", "Info", "Your code sucks!", DateTime.Now));
            errors.Add(new ErrorModel(125, "Jobby", "Critical", "Your code sucks!", DateTime.Now));
            errors.Add(new ErrorModel(1223, "Out of Ideas", "Exception", "Your code sucks!", DateTime.Now));
            errors.Add(new ErrorModel(11, "Clusterfuck", "Critical", "Your code sucks!", DateTime.Now));
            return View(errors);
        }
    }
}
