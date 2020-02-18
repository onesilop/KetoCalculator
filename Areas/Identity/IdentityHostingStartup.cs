using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(KetoCalculator.Areas.Identity.IdentityHostingStartup))]
namespace KetoCalculator.Areas.Identity
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