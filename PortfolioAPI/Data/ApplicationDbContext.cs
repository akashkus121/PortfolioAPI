//using Microsoft.Azure.KeyVault.Models;
using Microsoft.EntityFrameworkCore;
using PortfolioAPI.Models;


namespace PortfolioAPI.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }

        // ✅ This should be INSIDE the class
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 1,
                    Title = "Health Check Web App",
                    Description = "Daily mood, exercise, and food logging app with AI tips.",
                    TechStack = "ASP.NET Core, React.js, SQL Server",
                    GitHubLink = "https://github.com/akashkushwaha/health-app",
                    LiveDemoLink = "https://akash-health-app.vercel.app"
                },
                new Project
                {
                    Id = 2,
                    Title = "Expense Tracker",
                    Description = "Track monthly income and expenses with charts.",
                    TechStack = "React, Node.js, MongoDB",
                    GitHubLink = "https://github.com/akashkushwaha/expense-tracker",
                    LiveDemoLink = "https://akash-expense-app.vercel.app"
                }
            );

            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = 1, Name = "C#", Category = "Backend" },
                new Skill { Id = 2, Name = "ASP.NET Core", Category = "Backend" },
                new Skill { Id = 3, Name = "React.js", Category = "Frontend" },
                new Skill { Id = 4, Name = "SQL Server", Category = "Database" },
                new Skill { Id = 5, Name = "Git & GitHub", Category = "Tools" }
            );
        }
    }
}
