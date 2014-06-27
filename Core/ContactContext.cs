using System.Data.Entity;

namespace Core
{
	public class ContactContext : DbContext
	{
		public ContactContext() : base("DefaultConnection")
		{}

		public virtual DbSet<Contact> Contacts { get; set; }
		public virtual DbSet<Skill> Skills { get; set; }
	}
}