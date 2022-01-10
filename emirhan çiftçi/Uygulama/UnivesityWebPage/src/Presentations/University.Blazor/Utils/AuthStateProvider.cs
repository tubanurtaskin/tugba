﻿using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using University.Blazor.Extensions;
using University.Blazor.Infrastructure;

namespace University.Blazor.Utils
{
    public class AuthStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService localStorageService;
        private readonly HttpClient client;
        private readonly AuthenticationState anonymous;
        private readonly AppStateManager appState;


        public AuthStateProvider(ILocalStorageService LocalStorageService, IHttpClientFactory factory, AppStateManager appState)
        {
            localStorageService = LocalStorageService;
            client = factory.CreateClient("University");
            anonymous = new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            this.appState = appState;
        }

        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            String apiToken = await localStorageService.GetToken();

            if (String.IsNullOrEmpty(apiToken))
                return anonymous;

            String userName = await localStorageService.GetUsername();

            var cp = new ClaimsPrincipal(new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, userName)

            }, "jwtAuthType"));

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiToken);

            return new AuthenticationState(cp);
        }

        public void NotifyUserLogin(String userName)
        {
            var cp = new ClaimsPrincipal(new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, userName)

            }, "jwtAuthType"));

            var authState = Task.FromResult(new AuthenticationState(cp));

            NotifyAuthenticationStateChanged(authState);
            appState.LoginChanged(null);
        }

        public void NotifyUserLogout()
        {
            var authState = Task.FromResult(anonymous);
            NotifyAuthenticationStateChanged(authState);
            appState.LoginChanged(null);
        }
    }
}
