using Databaseconnectivity2.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Databaseconnectivity2.controler
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Home
        public ActionResult Index()
        {
            var res = db.Employee.ToList();
            return View(res);
        }
    }
}