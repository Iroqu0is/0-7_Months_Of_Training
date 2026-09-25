namespace SplitTable
{
    public class Context : DbContext
    {
        // public DbSet<> Ents { get; set; }
        // public DbSet<> Ents { get; set; }
        // public DbSet<> Ents { get; set; }
        // public DbSet<> Ents { get; set; }

        public async Task<bool> ResetAsync(CancellationToken token = default)
        {
            await Database.EnsureDeletedAsync(token);
            return await Database.EnsureCreatedAsync(token);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test_2;Integrated Security=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}