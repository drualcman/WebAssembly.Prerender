using Blazor.LazyLoading;
using Blazor.LazyLoading.Interfaces;
using Blazor.LazyLoading.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Globalization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton<ILazyLoadModules, LazyLoadModules>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });      
        //force to use the culture from the country about the app.
        CultureInfo.CurrentCulture = new CultureInfo("en-AU");
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-AU");
        CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-AU");

await builder.Build().RunAsync();
