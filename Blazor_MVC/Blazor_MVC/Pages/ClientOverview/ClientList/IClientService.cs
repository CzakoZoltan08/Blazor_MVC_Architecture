using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor_MVC.Pages.ClientOverview.ClientList
{
    public interface IClientService
    {
        Task<IList<ClientModel>> GetClients();
    }
}
