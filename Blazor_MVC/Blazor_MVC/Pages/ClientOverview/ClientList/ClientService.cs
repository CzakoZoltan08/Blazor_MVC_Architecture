using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Blazor_MVC.Pages.ClientOverview.ClientList
{
    public class ClientService : IClientService
    {
        private readonly HttpClient httpClient;

        public ClientService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IList<ClientModel>> GetClients()
        {
            return await httpClient.GetJsonAsync<ClientModel[]>("sample-data/clients.json");
        }
    }
}
