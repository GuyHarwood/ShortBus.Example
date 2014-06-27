using System;
using ShortBus;

namespace Core
{
	public class Update : ICommand
	{
		private readonly DateTime created;

		public Update()
		{
			created = DateTime.Now;
		}

		public DateTime Created
		{
			get { return created; }
		}
	}
}