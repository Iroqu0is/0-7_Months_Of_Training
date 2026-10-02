namespace BookShop
{
    public class BookAuthorsConfiguration : IEntityTypeConfiguration<BookAuthors>
    {
        public void Configure(EntityTypeBuilder<BookAuthors> builder)
        {
            builder.ToTable("BookAuthors");
            builder.HasKey(ba => new { ba.BookId, ba.AuthorId });

            builder.HasOne(ba => ba.Book)
                   .WithMany(b => b.BookAuthors)
                   .HasForeignKey(ba => ba.BookId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ba => ba.Author)
                   .WithMany(a => a.BookAuthors)
                   .HasForeignKey(ba => ba.AuthorId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.OwnsOne(ba => ba.Description, DescriptionConfiguration.Configure);

            builder.Property(ba => ba.BookId)
                   .HasColumnName("BookId")
                   .ValueGeneratedNever()
                   .IsRequired(true);

            builder.Property(ba => ba.AuthorId)
                   .HasColumnName("AuthorId")
                   .ValueGeneratedNever()
                   .IsRequired(true);
        }
    }
}