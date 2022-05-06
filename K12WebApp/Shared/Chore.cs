using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace K12WebApp.Shared
{
	public class Chore
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public List<ChoreMonth> ChoreMonths { get; set; }
	}
}

