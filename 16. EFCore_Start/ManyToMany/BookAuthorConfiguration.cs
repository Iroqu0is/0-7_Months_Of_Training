namespace ManyToMany
{
    public class BookAuthorConfiguration : IEntityTypeConfiguration<BookAuthors>
    {
        public void Configure(EntityTypeBuilder<BookAuthors> builder)
        {
            builder.ToTable("BookAuthors");
            builder.HasKey(ba => new { ba.BookId, ba.AuthorId });

            builder.HasOne(ba => ba.Book)
                   .WithMany(book => book.BookAuthors)
                   .HasForeignKey(ba => ba.BookId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ba => ba.Author)
                   .WithMany(author => author.BookAuthors)
                   .HasForeignKey(ba => ba.AuthorId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.OwnsOne(ba => ba.Description, DescriptionConfiguration.Configure);

            builder.Property(ba => ba.BookId)
                   .HasColumnName("Key_From_BooksTable")
                   .IsRequired(true);

            builder.Property(ba => ba.AuthorId)
                   .HasColumnName("Key_From_AuthorsTable")
                   .IsRequired(true);
        }
    }
}