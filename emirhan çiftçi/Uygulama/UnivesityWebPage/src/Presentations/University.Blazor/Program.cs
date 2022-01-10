
using University.Blazor.Infrastructure;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddBlazoredLocalStorage();

builder.Services.AddTransient<IIdentityService, IdentityService>();
builder.Services.AddScoped<IUniversityService, UniversityService>();
builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();


builder.Services.AddSingleton<AppStateManager>();

builder.Services.AddHttpClient("University", c =>
{
    c.BaseAddress = new Uri("http://localhost:5000/api/");
    c.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
    c.DefaultRequestHeaders.Add("User-Agent", "HttpClientFactory-Sample");
});


var assm = Assembly.GetExecutingAssembly();
builder.Services.AddAutoMapper(assm);

var app = builder.Build();

await app.RunAsync();