using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Cookery.ApplicationCore.Models;

namespace Cookery.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeStep> RecipeSteps { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<NutritionalInformation> nutritionalInformations { get; set; }

        public DbSet<Difficulty> Difficulties { get; set; } 

    }
}