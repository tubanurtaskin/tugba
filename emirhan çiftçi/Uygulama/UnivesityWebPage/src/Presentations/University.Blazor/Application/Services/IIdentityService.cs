namespace University.Blazor.Application.Services
{
    public interface IIdentityService
    {
        string GetUserName();

        string GetUserToken();

        bool IsLoggedIn { get; }

        Task<bool> Login(string userName, string password);

        void Logout();
    }
}
