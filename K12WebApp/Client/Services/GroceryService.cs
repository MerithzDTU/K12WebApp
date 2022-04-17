using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace K12WebApp.Client.Services
{
    public class GroceryService : IGroceryService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public GroceryService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        public List<Grocery> Groceries { get; set; } = new List<Grocery>();
        public List<User> Users { get; set; } = new List<User>();

        public async Task CreateGrocery(Grocery grocery)
        {
            var result = await _http.PostAsJsonAsync("api/grocery", grocery);
            await SetGroceries(result);
        }

        private async Task SetGroceries(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Grocery>>();
            Groceries = response;
            Console.WriteLine("Size of list Groceries ----> : " + Groceries.Count);
            _navigationManager.NavigateTo("groceries");
        }


        public async Task DeleteGrocery(int id)
        {
            var result = await _http.DeleteAsync($"api/grocery/{id}");
            await SetGroceries(result);
        }

        public async Task GetGroceries()
        {
            var result = await _http.GetFromJsonAsync<List<Grocery>>("api/grocery");
            if (result != null)
                Groceries = result;
        }

        public async Task<Grocery> GetGroceryById(int id)
        {
            var result = await _http.GetFromJsonAsync<Grocery>($"api/grocery/{id}");
            if (result != null)
                return result;
            throw new Exception("Grocery not found!");
        }

        public async Task GetUsers()
        {
            var result = await _http.GetFromJsonAsync<List<User>>("api/grocery/users");
            if (result != null)
                Users = result;
        }

        public async Task UpdateGrocery(Grocery grocery)
        {
            var result = await _http.PutAsJsonAsync($"api/grocery/{grocery.Id}", grocery);
            await SetGroceries(result);
        }
    }
}
