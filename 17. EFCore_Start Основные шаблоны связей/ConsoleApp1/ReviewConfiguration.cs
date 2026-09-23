namespace ConsoleApp1
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.ToTable("Reviews");
            builder.HasKey(review => review.Id);

            builder.HasOne(review => review.Book)
                   .WithMany(review => review.Reviews)
                   .HasForeignKey(review => review.BookId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.Property(review => review.BookId)
                   .HasColumnName("BookId")
                   .IsRequired(true);

            builder.Property(review => review.Text)
                   .HasColumnName("Review")
                   .HasMaxLength(500)
                   .IsRequired(true);
        }
    }
}