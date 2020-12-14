using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje_Dinamik.Models.Context;
using Proje_Dinamik.Models.Entity;
using System.Data.Entity;

namespace Proje_Dinamik.Controllers
{
	public class HomeController : Controller
	{
		Context data = new Context();
		[Authorize]
		public ActionResult Index()
		{
			var values = data.Customers.ToList();
			return View(values);
		}
		[Authorize]
		[HttpGet] // sayfayı olduğu gibi dönderiyoruz.
		public ActionResult CustomerAdd()
		{
			return View();
		}
		[Authorize]
		[HttpPost] // ekleme gerçekleştirilirse dönderiyor.
		public ActionResult CustomerAdd(Customer c)
		{
			data.Customers.Add(c);
			data.SaveChanges();
			return RedirectToAction("Index");
		}

		public ActionResult CustomerDelete(int ID)
		{
			var value = data.Customers.Find(ID);
			data.Customers.Remove(value);
			data.SaveChanges();

			return RedirectToAction("Index");
		}
		[HttpGet]
		public ActionResult CustomerUpdate(int id)
		{
			var value1 = data.Customers.Find(id);
			return View("CustomerUpdate", value1);
		}

		[HttpPost]
		public ActionResult CustomerUpdate(Customer cs)
		{
			var x = data.Customers.Find(cs.customerID);

			x.customerName = cs.customerName;
			x.customerSurname = cs.customerSurname;
			x.customerAge = cs.customerAge;
			x.customerGender = cs.customerGender;
			x.customTelephone = cs.customTelephone;
			x.customerAdress = cs.customerAdress;
			data.SaveChanges();

			return RedirectToAction("Index");
		}


		public ActionResult CustomerDetails(int id)
		{
			var value2 = data.Customers.Find(id);
			return View("CustomerDetails", value2);

		}

		[Authorize]
		public ActionResult Details()
		{
			var values = data.Customers.SqlQuery("customerDetails").ToList();
			return View(values);
		}

	}
}