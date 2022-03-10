namespace K12WebApp.Shared
{
    public class Grocery
    {
        public int Id { get; set; }
        public string GroceryName { get; set; } = string.Empty;
        public bool isBought { get; set; }
        public DateTime DateCreated { get; set; } 
        public DateTime? LastUpdated { get; set; }
        public User? CreatedByUser { get; set; }
        public int CreatedByUserId { get; set; }
    }
}
