using System.Collections.Generic;
using ShortBus;

namespace Core
{
	public class ContactsRequest : IQuery<IEnumerable<Contact>>
	{
		public IEnumerable<Contact> Contacts { get; set; }
	}
}