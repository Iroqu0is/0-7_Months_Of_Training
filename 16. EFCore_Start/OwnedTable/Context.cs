namespace OwnedTable
{
    public class Context : DbContext
    {
        public DbSet<Book> Books { get; set; }
        //  public DbSet<> Ents { get; set; }
        //  public DbSet<> Ents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test_3;Integrated Security=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.Ignore<Ents>();
        }
    }
}