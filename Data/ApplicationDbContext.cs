using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Portfolio_WebApp.Areas.AppUsers;
using Portfolio_WebApp.Models;

namespace Portfolio_WebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Portfolio_WebApp.Models.Joke> Jokes { get; set; } = default!;
    }
}