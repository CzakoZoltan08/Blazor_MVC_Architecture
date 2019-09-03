using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Blazor_MVC.Pages.ClientOverview.ClientList
{
    public class ClientListComponent : ComponentBase
    {
        public IList<ClientModel> Clients;

        [Inject]
        public IClientService clientService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Clients = await clientService.GetClients();
        }
    }
}
