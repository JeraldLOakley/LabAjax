using LabAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabAjax.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		[HttpPost]
		public ActionResult GetBookByTitle(string bookTitle)
		{
			LibraryEntities db = new LibraryEntities();


			List<book> list = db.books.Where(
			   b => b.Title.Contains(bookTitle)
				).ToList();

			return Json(list);
		}

		[HttpPost]
		public ActionResult GetBookByAuthor(string bookAuthor)
		{
			LibraryEntities db = new LibraryEntities();


			List<book> list = db.books.Where(
			   b => b.Author.Contains(bookAuthor)
				).ToList();

			return Json(list);
		}

		[HttpPost]
		public ActionResult GetBookByYearPublished(int? PubYear)
		{
			LibraryEntities db = new LibraryEntities();


			List<book> list = db.books.Where(
			   b => b.YearPublished == PubYear
				).ToList();

			return Json(list);
		}
	}
}