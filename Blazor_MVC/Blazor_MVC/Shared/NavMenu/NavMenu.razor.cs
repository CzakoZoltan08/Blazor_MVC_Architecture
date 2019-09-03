using Microsoft.AspNetCore.Components;

namespace Blazor_MVC.Shared.NavMenu
{
    public class NavMenuComponent : ComponentBase
    {
        public bool CollapseNavMenu = true;

        public string NavMenuCssClass => CollapseNavMenu ? "collapse" : null;

        public void ToggleNavMenu()
        {
            CollapseNavMenu = !CollapseNavMenu;
        }
    }
}
