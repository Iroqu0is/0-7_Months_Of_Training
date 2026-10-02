namespace BookShop
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.ToTable("Reviews");
            builder.HasKey(r => r.Id);

            builder.HasOne(r => r.Book)
                   .WithMany(b => b.Reviews)
                   .HasForeignKey(r => r.BookId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.Property(r => r.Id)
                   .HasColumnName("Id")
                   .IsRequired(true);

            builder.Property(r => r.BookId)
                   .HasColumnName("BookId")
                   .IsRequired(true);

            builder.Property(r => r.Comment)
                   .HasColumnName("Comment")
                   .HasMaxLength(1024)
                   .IsRequired(true);
        }
    }
}