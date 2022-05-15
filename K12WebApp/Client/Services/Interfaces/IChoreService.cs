namespace K12WebApp.Client.Services
{
    public interface IChoreService
    {
        List<Chore> Chores { get; set; }
        List<ChoreMonth> ChoreMonths { get; set; }
        List<UserChore> ChoreMonthUsers { get; set; }
        Task GetChores();
        Task GetChoreMonths();
        Task GetUserChores();
        Task<Chore> GetChoreById(int id);
        Task CreateChore(Chore chore);
        Task UpdateChore(Chore chore);
        Task DeleteChore(int id);
    }
}
