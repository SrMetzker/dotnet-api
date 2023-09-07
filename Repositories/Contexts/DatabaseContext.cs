using dotnet_api.Models.ClientModels;
using dotnet_api.Models.UserModels;
using Microsoft.EntityFrameworkCore;

namespace dotnet_api.Repositories.Contexts
{
    public class DatabaseContext : DbContext
    {
        public DbSet<ClientModel>? Client { get; set; } = null;
        public DbSet<UserModel>?   User   { get; set; } = null;

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
    }
}
