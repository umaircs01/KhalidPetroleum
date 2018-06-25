using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhalidPetroleum.Controllers
{
    public class MainController : Controller
    {
        //
        // GET: /Main/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignIn()
        {
            return View();
        }
		public ActionResult SalePurchase()
        {
            return View();
        }
		public ActionResult Checklist()
        {
            return View();
        }
		public ActionResult Attendance()
		{
			return View();
		}
		public ActionResult DailyExpenses()
        {
            return View();
        }
		public ActionResult CashReceived()
        {
            return View();
        }
		public ActionResult Payments()
        {
            return View();
        }
    }
}
