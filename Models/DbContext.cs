using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace GlamCart.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
    {

    }
    public DbSet<Product> Products { get; set; } = default!;
    public DbSet<Review> Reviews { get; set; } = default!;
}