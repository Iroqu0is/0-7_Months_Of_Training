namespace OneToMany
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            builder.HasKey(book => book.Id);

            builder.Property(book => book.Id)
                   .HasColumnName("Id")
                   .IsRequired(true);

            builder.Property(book => book.Id)
                   .HasColumnName("Title")
                   .HasMaxLength(200)
                   .IsRequired(true);
        }
    }
}