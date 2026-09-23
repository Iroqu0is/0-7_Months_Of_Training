namespace ConsoleApp1
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Authors");
            builder.HasKey(author => author.Id);

            builder.HasMany(author => author.Books).WithMany(book => book.Authors);

            builder.Property(author => author.Id)
                   .HasColumnName("Id")
                   .IsRequired(true);

            builder.Property(author => author.Name)
                   .HasColumnName("FullName")
                   .HasMaxLength(100)
                   .IsRequired(true);
        }
    }
}