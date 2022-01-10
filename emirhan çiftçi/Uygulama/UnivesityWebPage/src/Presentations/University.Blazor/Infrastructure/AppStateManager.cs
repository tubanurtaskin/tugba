using Microsoft.AspNetCore.Components;

namespace University.Blazor.Infrastructure
{
    public class AppStateManager
    {
        public event Action<ComponentBase, string> StateChanged;

        public void LoginChanged(ComponentBase component)
        {
            StateChanged?.Invoke(component, "login");
        }

    }
}
