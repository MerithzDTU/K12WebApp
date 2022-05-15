using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace K12WebApp.Client.Services
{
    public class ChoreService : IChoreService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;
        public ChoreService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager; 
        }
        public List<Chore> Chores { get; set; } = new List<Chore>();
        public List<ChoreMonth> ChoreMonths { get; set; } = new List<ChoreMonth>();
        public List<UserChore> ChoreMonthUsers { get; set; } = new List<UserChore>();

        public async Task CreateChore(Chore chore)
        {
            var result = await _http.PostAsJsonAsync("api/chore", chore);
            await SetChores(result);
        }

        private async Task SetChores(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Chore>>();
            Chores = response!;
            _navigationManager.NavigateTo("chores");
        }

        public async Task DeleteChore(int id)
        {
            var result = await _http.DeleteAsync($"api/chore/{id}");
            await SetChores(result);
        }

        public async Task GetChoreMonths()
        {
            var result = await _http.GetFromJsonAsync<List<ChoreMonth>>("api/chore/choremonths");
            if (result != null)
                ChoreMonths = result;
        }

        public async Task GetUserChores()
        {
            var result = await _http.GetFromJsonAsync<List<UserChore>>("api/chore/userchores");
            if (result != null)
                ChoreMonthUsers = result;
        }

        public async Task<Chore> GetChoreById(int id)
        {
            var result = await _http.GetFromJsonAsync<Chore>($"api/chore/{id}");
            if (result != null)
                return result;
            throw new Exception("Chore not found!");
        }

        public async Task GetChores()
        {
            var result = await _http.GetFromJsonAsync<List<Chore>>("api/chore");
            if (result != null)
                Chores = result;
        }

        public async Task UpdateChore(Chore chore)
        {
            var result = await _http.PutAsJsonAsync($"api/chore/{chore.Id}", chore);
            await SetChores(result);
        }
    }
}
