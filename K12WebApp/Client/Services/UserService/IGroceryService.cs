namespace K12WebApp.Client.Services.UserService
{
    public interface IGroceryService
    {
        List<Grocery> Groceries { get; set; }
        List<User> Users { get; set; }
        Task GetUsers();
        Task GetGroceries();
        Task<Grocery> GetGroceryById(int id);
        Task CreateGrocery(Grocery grocery);
        Task UpdateGrocery(Grocery grocery);
        Task DeleteGrocery(int id);

    }
}
