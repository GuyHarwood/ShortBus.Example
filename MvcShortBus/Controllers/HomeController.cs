using System.Web.Mvc;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Core;
using MvcShortBus.Models;

namespace MvcShortBus.Controllers
{
	public class HomeController : Controller
	{
		private readonly ContactContext db;

		public HomeController()
		{
			db = new ContactContext();
			db.Configuration.AutoDetectChangesEnabled = false;
		}

		public HomeController(ContactContext db)
		{
			this.db = db;
		}

		public ActionResult Index()
		{
			var model = new HomeIndexModel
			{
				ActiveContacts = db.Contacts.Project().To<ContactItem>()
			};
			return View(model);
		}

		public ActionResult Add()
		{
			return View(new HomeAddModel());
		}

		[HttpPost]
		public ActionResult Add(HomeAddModel model)
		{
			var contact = Mapper.Map<Contact>(model);
			db.Contacts.Add(contact);
			db.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}