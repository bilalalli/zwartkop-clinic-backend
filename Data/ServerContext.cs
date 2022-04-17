using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Data;

public class ServerContext : DbContext
{
    public ServerContext (DbContextOptions<ServerContext> options)
        : base(options)
    {
    }

    public DbSet<Pizza> Pizzas => Set<Pizza>();
}