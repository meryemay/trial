using OnlineCourse.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineCourse.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
			

            return View();
        }

		public ActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Login(LoginViewModel model)
		{
			return View();
		}


		public ActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Register(RegisterViewModel model)
		{
			return View();
		}
		public ActionResult Logout()
		{
			return View();
		}

		public ActionResult KursEkle()
		{
			return View();
		}

		public ActionResult KisiHesap()
		{
			return View();
		}
	}
}