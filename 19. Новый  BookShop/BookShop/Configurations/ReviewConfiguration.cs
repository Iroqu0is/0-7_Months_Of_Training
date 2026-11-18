namespace BookShop.Configurations
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
                   .HasColumnName("Id");

            builder.Property(r => r.Text)
                   .HasColumnName("Review")
                   .HasMaxLength(500);
        }
    }
}