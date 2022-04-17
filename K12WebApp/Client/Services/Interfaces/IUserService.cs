namespace K12WebApp.Client.Services
{
    public interface IUserService
    {
        List<User> Users { get; set; }
        List<Role> Roles { get; set; }
        Task GetRoles();
        Task GetUsers();
        Task<User> GetUserById(int id);
        Task CreateUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(int id);
    }
}
