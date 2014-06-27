using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core
{
	public class Contact
	{
		public Contact()
		{
			Skills = new HashSet<Skill>();
		}

		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ContactId { get; set; }
		
		public string Name { get; set; }
		public bool Active { get; set; }

		public virtual HashSet<Skill> Skills { get; set; }
	}
}