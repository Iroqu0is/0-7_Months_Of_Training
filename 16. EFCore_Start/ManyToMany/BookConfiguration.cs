namespace ManyToMany
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            builder.HasKey(author => author.Id);

            builder.Property(book => book.Id)
                   .HasColumnName("Id")
                   .IsRequired(true);

            builder.Property(book => book.Name)
                   .HasColumnName("Name")
                   .HasMaxLength(200)
                   .IsRequired(true);
        }
    }
}