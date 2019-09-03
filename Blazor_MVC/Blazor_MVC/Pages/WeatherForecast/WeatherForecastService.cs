using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Blazor_MVC.Pages.WeatherForecast
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient httpClient;

        public WeatherForecastService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<WeatherForecastModel[]> GetWeatherForecasts()
        {
            return await httpClient.GetJsonAsync<WeatherForecastModel[]>("sample-data/weather.json");
        }
    }
}
