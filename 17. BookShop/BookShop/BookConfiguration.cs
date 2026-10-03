namespace BookShop
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            builder.HasKey(b => b.BookId);

            builder.Property(b => b.BookId)
                   .HasColumnName("BookId")
                   .IsRequired(true);

            builder.Property(b => b.Title)
                   .HasColumnName("Title")
                   .HasMaxLength(200)
                   .IsRequired(true);
        }
    }
}