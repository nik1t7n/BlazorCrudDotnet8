using BlazorCrudDotnet8.Shared.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// register an HttpClient service with a base address
builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
});

// ensures that a new instance of the ClientGameService will be created for each request
builder.Services.AddScoped<IGameService, ClientGameService>();

await builder.Build().RunAsync();
