using System;
namespace K12WebApp.Shared
{
	public class ChoreMonth
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public ICollection<User> AssignedUser { get; set; } 
		public List<int> AssignedUserId { get; set; }

	}
}

