using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Blazor_MVC.Pages.WeatherForecast
{
    public class WeatherForecastComponent : ComponentBase
    {
        public WeatherForecastModel[] forecasts;

        [Inject]
        public IWeatherForecastService weatherForecastService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            forecasts = await weatherForecastService.GetWeatherForecasts();
        }
    }
}
