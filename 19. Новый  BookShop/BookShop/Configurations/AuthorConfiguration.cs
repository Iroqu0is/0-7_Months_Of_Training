namespace BookShop.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Authors");
            builder.HasKey(a => a.Id);
            builder.HasIndex(a => a.Name);

            builder.ComplexProperty(a => a.Description, DescriptionForAuthorConfiguration.Configure);

            builder.Property(a => a.Id)
                   .HasColumnName("Id");

            builder.Property(a => a.Name)
                   .HasColumnName("Name")
                   .HasMaxLength(100);
        }
    }
}