using Blazor_MVC.Pages.ClientOverview.ClientList;
using Blazor_MVC.Pages.WeatherForecast;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor_MVC
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IWeatherForecastService, WeatherForecastService>();
            services.AddSingleton<IClientService, ClientService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
