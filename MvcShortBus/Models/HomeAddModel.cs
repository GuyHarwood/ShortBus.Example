using System.ComponentModel.DataAnnotations;

namespace MvcShortBus.Models
{
	public class HomeAddModel
	{
		[MinLength(10)]
		public string Name { get; set; }
	}
}