namespace K12WebApp.Shared
{
    public class Grocery
    {
        public int Id { get; set; }
        public string GroceryName { get; set; } = string.Empty;
        public bool isBought { get; set; }
        public DateTime DateCreated { get; set; } 

    }
}
