global using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Application.Entity;

public class ApplicatioDbContext : DbContext
{
    public ApplicatioDbContext()
    {
    }
    public ApplicatioDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Dish> Dishs { get; set; }
    public DbSet<Ingridien> ingridiens { get; set; }
    public DbSet<DishIngridien> dishIngridiens { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=C:\Users\User\Desktop\Programy\Food Application\DB\FoodCalculatorDB.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dish>(eb =>
        eb.HasMany(D => D.ingridiens)
        .WithOne (I => I.Dish)
        .HasForeignKey (I => I.DishId)
        );
    }
}
