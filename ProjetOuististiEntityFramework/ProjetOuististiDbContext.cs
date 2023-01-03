using Microsoft.EntityFrameworkCore;
using ProjetOuististiDomain.Calculs;


namespace ProjetOuististiEntityFramework
{
    public class ProjetOuististiDbContext : DbContext
    {
        public DbSet<CalculAbstract> Calculs { get; set; }
        public DbSet<CalculAddition> CalculAdditions { get; set; }
        public DbSet<CalculSoustraction> CalculSoustractions { get; set; }
        public DbSet<CalculMultiplication> CalculMultiplications { get; set; }
        public DbSet<CalculDivision> calculDivisions { get; set; }

        public string DbPath { get; }

        public ProjetOuististiDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "ProjetOuististiOuististi.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

    }
}
