using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

// public class AppDBContext(DbContextOptions<AppDBContext> options) : IdentityDbContext<User>(options);
// public class AppDBContext(DbContextOptions<AppDBContext> options) : IdentityDbContext<User>(options);

public class AppDBContext : IdentityDbContext<User>
{
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {
        
    }
}