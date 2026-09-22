namespace ConsoleApp2
{
    public class Context : DbContext
    {
        public DbSet<Position> Positions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }

        public async Task<bool> Reset(CancellationToken token = default)
        {
            await Database.EnsureDeletedAsync(token);
            return await Database.EnsureCreatedAsync(token);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CompaniesDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.Ignore<>();
        }
    }
}