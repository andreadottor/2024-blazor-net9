namespace WPC.Dottor.BlazorNet9.Client.Components;

using Microsoft.AspNetCore.Components;

public class RedirectToLogin (NavigationManager navigationManager) : ComponentBase
{
    protected override void OnInitialized()
    {
        navigationManager.NavigateTo($"Account/Login?returnUrl={Uri.EscapeDataString(navigationManager.Uri)}", forceLoad: true);
    }
}
