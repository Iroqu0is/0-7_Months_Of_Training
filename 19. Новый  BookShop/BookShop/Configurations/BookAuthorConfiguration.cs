namespace BookShop.Configurations
{
    public class BookAuthorConfiguration : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.ToTable("BookAuthor");
            builder.HasKey(ba => new { ba.BookId, ba.AuthorId });

            builder.HasOne(ba => ba.Book)
                   .WithMany(b => b.BookAuthor)
                   .HasForeignKey(ba => ba.BookId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ba => ba.Author)
                   .WithMany(a => a.BookAuthor)
                   .HasForeignKey(ba => ba.AuthorId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.Property(ba => ba.BookId)
                   .HasColumnName("BookId");

            builder.Property(ba => ba.AuthorId)
                   .HasColumnName("AuthorId");
        }
    }
}