using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Core
{
	public class DataBuilder : DropCreateDatabaseIfModelChanges<ContactContext>
	{
		protected override void Seed(ContactContext context)
		{
			var contacts = new List<Contact>
			{
				new Contact {Name = "Carson"},
				new Contact {Name = "Meredith"},
				new Contact {Name = "Arturo"},
				new Contact {Name = "Gytis"},
				new Contact {Name = "Yan"},
				new Contact {Name = "Peggy"},
				new Contact {Name = "Laura"},
				new Contact {Name = "Nino"}
			};

			contacts.ForEach(s => context.Contacts.Add(s));
			context.SaveChanges();
			var skills = new List<Skill>
			{
				new Skill {Title = "Chemistry"},
				new Skill {Title = "Microeconomics"},
				new Skill {Title = "Macroeconomics"},
				new Skill {Title = "Calculus"},
				new Skill {Title = "Trigonometry"},
				new Skill {Title = "Composition"},
				new Skill {Title = "Literature"}
			};
			skills.ForEach(s => context.Skills.Add(s));
			context.SaveChanges();

			var rand = new Random();
			var upperBound = skills.ToArray().GetUpperBound(0);

			foreach (var contact in contacts)
			{
				contact.Skills.Add(skills[rand.Next(0, upperBound)]);
			}

			context.SaveChanges();
		}
	}
}