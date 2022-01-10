using Microsoft.OpenApi.Models;
using University.Persistence.Context;
using University.WebAPI.Extensions;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      builder =>
                      {
                          builder.WithOrigins("http://localhost:2000")
                                 .AllowAnyHeader()
                                 .AllowAnyMethod();
                      });
});

ConfigureService(builder.Services);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] { }
        }
    });
});
builder.Services.ConfigureAuth(builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseAuthorization();

app.UseCors(MyAllowSpecificOrigins);

app.MapControllers();

app.MigrateDbContext<UniversityDbContext>((context, services) =>
{
    var logger = services.GetService<ILogger<UniversityDbContext>>();

    var dbContextSeeder = new UniversityDbContextSeed();
    dbContextSeeder.SeedAsync(context, logger)
        .Wait();
});

app.Run();


void ConfigureService(IServiceCollection services)
{
    services
        .AddLogging(configure => configure.AddConsole())
        .AddApplicationRegistration(typeof(Program))
        .AddPersistenceRegistration(builder.Configuration);
}