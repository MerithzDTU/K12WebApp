global using K12WebApp.Client.Services;
global using K12WebApp.Shared;
global using Microsoft.AspNetCore.Components.Authorization;
global using Blazored.LocalStorage;
global using MudBlazor.Services;
using K12WebApp.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


//Authentication
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

//Authorization and local storage
builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredLocalStorage();

// Custom Services
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IGroceryService, GroceryService>();
builder.Services.AddScoped<IAuthService, AuthService>();

// MudBlazor
builder.Services.AddMudServices();

await builder.Build().RunAsync();
