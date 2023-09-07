using dotnet_api.Endpoints;
using dotnet_api.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseContext>(options =>
{
    const string connectionString = @"Data Source=ApiTesting.db;";
    options.UseSqlite(connectionString);
});

WebApplication app = builder.Build();

using (IServiceScope scope = app.Services.CreateScope())
{
    DatabaseContext dbContext = scope.ServiceProvider.GetRequiredService<DatabaseContext>(); // 2
    dbContext.Database.EnsureCreated();
}

app.MapGet("/", () => "Hello World!");

RouteGroupBuilder userGroup = app.MapGroup("user");
userGroup.MapUserEndpoints();

RouteGroupBuilder clientGroup = app.MapGroup("client");
clientGroup.MapClientEndpoints();

app.Run();
