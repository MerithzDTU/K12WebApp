using System.Collections.Generic;
namespace K12WebApp.Shared
{
	public class ChoreMonth
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public int ChoreId { get; set; }
		public IList<UserChore>? UserChores { get; set; }
    }
}

