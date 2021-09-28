using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Blazor;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazingDewey.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDk1NzU2QDMxMzkyZTMyMmUzME5qRXE0bC9hL1hVdkNDaUl2aGxCTlpHOVl2d0VXSlVVNTEzdENUcm9DT0k9");
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSyncfusionBlazor();
            await builder.Build().RunAsync();
        }
    }
}
