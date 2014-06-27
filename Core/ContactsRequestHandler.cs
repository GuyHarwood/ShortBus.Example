using System.Collections.Generic;
using System.Linq;
using ShortBus;

namespace Core
{
	public class ContactsRequestHandler : IQueryHandler<ContactsRequest, IEnumerable<Contact>>
	{
		private readonly ContactContext db;

		public ContactsRequestHandler(ContactContext db)
		{
			this.db = db;
		}

		public IEnumerable<Contact> Handle(ContactsRequest request)
		{
			var query = from c in db.Contacts
				select c;

			return query.ToArray();
		}
	}
}