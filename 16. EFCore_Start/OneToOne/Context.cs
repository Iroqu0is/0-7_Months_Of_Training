namespace OneToOne
{
    public class Context : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Price> Prices { get; set; }

        public async Task<bool> ResetAsync(CancellationToken token = default) // это просто для тестов
        {
            await Database.EnsureDeletedAsync(token);
            return await Database.EnsureCreatedAsync(token);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}