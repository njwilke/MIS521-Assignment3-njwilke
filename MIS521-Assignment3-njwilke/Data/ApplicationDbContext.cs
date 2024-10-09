using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MIS521_Assignment3_njwilke.Models;

namespace MIS521_Assignment3_njwilke.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MIS521_Assignment3_njwilke.Models.Actor> Actor { get; set; } = default!;
        public DbSet<MIS521_Assignment3_njwilke.Models.Movie> Movie { get; set; } = default!;
        public DbSet<MIS521_Assignment3_njwilke.Models.MovieActor> MovieActor { get; set; } = default!;
    }
}
