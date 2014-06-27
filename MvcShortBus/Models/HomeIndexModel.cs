using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcShortBus.Models
{
	public class HomeIndexModel
	{
		public IEnumerable<ContactItem> ActiveContacts { get; set; }
	}

	public class ContactItem
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
}