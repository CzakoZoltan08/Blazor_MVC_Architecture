using System.Net.Http;
using System.Threading.Tasks;
using Blazor_MVC.Core.Models;

namespace Blazor_MVC.Core
{
    public interface IAppState
    {
        bool IsLoggedIn { get; set; }

        string Token { get; set; }

        User User { get; set; }

        Task<HttpResponseMessage> Login(User model);

        Task Logout();

        Task<bool> IsAuthenticated();

        Task SaveToken(HttpResponseMessage response);
    }
}
