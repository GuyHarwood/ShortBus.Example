using System.ComponentModel.DataAnnotations.Schema;

namespace Core
{
	public class Skill
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int SkillId { get; set; }

		public string Title { get; set; }
	}
}