using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Portfolio_Blazor;
using MudBlazor.Services; // MudBlazor Add Services

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#LoadMasterLayout");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices(); // MudBlazor Add Services

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
