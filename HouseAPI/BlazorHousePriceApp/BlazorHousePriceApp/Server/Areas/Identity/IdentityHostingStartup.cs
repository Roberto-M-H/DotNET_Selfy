using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(BlazorHousePriceApp.Server.Areas.Identity.IdentityHostingStartup))]
namespace BlazorHousePriceApp.Server.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}