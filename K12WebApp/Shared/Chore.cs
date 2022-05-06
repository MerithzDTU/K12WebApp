namespace K12WebApp.Shared
{
	public class Chore
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public User? AssignedUser { get; set; }
		public ICollection<int>? Months { get; set; }
	}
}

