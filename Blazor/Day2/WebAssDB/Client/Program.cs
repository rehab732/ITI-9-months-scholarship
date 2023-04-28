using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebAssDB;
using WebAssDB.Services;

namespace WebAssDB
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");


            builder.Services.AddHttpClient<ITrenieeDataServices, TrenieeDataServices>(
                client => client.BaseAddress = new Uri("https://localhost:7185")
                );

            builder.Services.AddHttpClient<ITrackDataServices, TrackDataServices>(
                client => client.BaseAddress = new Uri("https://localhost:7185")
                );


            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}