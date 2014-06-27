using System.Security.Cryptography;
using System.Web.Mvc;
using Core;
using MvcShortBus.Models;
using ShortBus;

namespace MvcShortBus.Controllers
{
	public class BusController : Controller
	{
		private readonly IMediator mediator;

		public BusController(IMediator mediator)
		{
			this.mediator = mediator;
		}

		public ActionResult Index()
		{
			var response = mediator.Request(new ContactsRequest());
			var model = new BusIndexModel()
			{
				Contacts = response.Data
			};
			return View(model);
		}

		public ActionResult Update()
		{
			mediator.Send(new Update());
			return RedirectToAction("Index");
		}
	}
}