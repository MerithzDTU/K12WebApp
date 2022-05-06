using System.Collections.Generic;
namespace K12WebApp.Shared
{
	public class ChoreMonth
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public List<User> AssignedUser { get; set; }
		public int ChoreId { get; set; }
    }
}

