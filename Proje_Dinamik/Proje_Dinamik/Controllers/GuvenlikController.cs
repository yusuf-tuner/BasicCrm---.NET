using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.Services.Description;
using System.Web.UI.HtmlControls;
using Proje_Dinamik.Models.Entity;
using Proje_Dinamik.Models.Context;

namespace Proje_Dinamik.Controllers
{
	public class GuvenlikController : Controller
	{
		// GET: Guvenlik

		Context db = new Context();
		public ActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Login(User us)
		{
			var values = db.Users.FirstOrDefault(x => x.userName == us.userName && x.userPass == us.userPass);
			if (values != null)
			{
				FormsAuthentication.SetAuthCookie(values.userName, false);
				return RedirectToAction("Index", "Home");
			}
			else
			{
				ModelState.AddModelError("","Hatalı Giriş Yaptınız. Lütfen Bilgilerinizi Kontrol Ediniz !!");
				return View("Login");
			}

		}

	}
}