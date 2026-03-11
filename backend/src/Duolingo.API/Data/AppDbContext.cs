using Duolingo.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Duolingo.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }

    public DbSet<User> Users => Set<User>();
}