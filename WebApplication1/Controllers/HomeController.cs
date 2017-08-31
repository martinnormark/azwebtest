using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Amazing app!";
			var identity = HttpContext.User.Identity;
			var claimsIdentity = identity as ClaimsIdentity;
			string s = "";

			foreach (var item in claimsIdentity.Claims)
			{
				s += "Claim: '" + item.Type + "' | Value: '" + item.Value + '";
			}

			ViewBag["debug"] = s;

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}
