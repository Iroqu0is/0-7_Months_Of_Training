namespace BookShop
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Authors");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
                   .HasColumnName("Id")
                   .IsRequired(true);

            builder.Property(a => a.Name)
                   .HasColumnName("Name")
                   .HasMaxLength(200)
                   .IsRequired(true);
        }
    }
}