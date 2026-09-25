namespace OneToOne
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");
            builder.HasKey(book => book.Id);

            builder.Property(book => book.Id)
                   .HasColumnName("ID")
                   .IsRequired(true);

            builder.Property(book => book.Name)
                   .HasColumnName("TITLE")
                   .HasMaxLength(100)
                   .IsRequired(true);
        }
    }
}