using System.Threading.Tasks;

namespace Blazor_MVC.Pages.WeatherForecast
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecastModel[]> GetWeatherForecasts();
    }
}
