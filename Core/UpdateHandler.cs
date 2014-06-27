using ShortBus;

namespace Core
{
	public class UpdateHandler : ICommandHandler<Update>
	{
		private readonly ContactContext db;

		public UpdateHandler(ContactContext db)
		{
			this.db = db;
		}

		public void Handle(Update message)
		{
			db.Contacts.Add(new Contact()
			{
				Name = string.Format("Created at {0}", message.Created.ToLongTimeString())
			});
			db.SaveChanges();
		}
	}
}