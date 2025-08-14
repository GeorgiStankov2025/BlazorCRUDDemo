using BlazorCRUDDemo.Shared.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(http => new HttpClient
{

    BaseAddress= new Uri(builder.Configuration.GetSection("BaseUri").Value!)

});

builder.Services.AddScoped<IProductService, ClientProductService>();

await builder.Build().RunAsync();
