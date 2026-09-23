namespace ConsoleApp1
{
    public class PriceConfiguration : IEntityTypeConfiguration<Price>
    {
        public void Configure(EntityTypeBuilder<Price> builder)
        {
            builder.ToTable("Prices");
            builder.HasKey(price => price.BookId);

            builder.HasOne(price => price.Book)
                   .WithOne(book => book.Price)
                   .HasForeignKey<Price>(price => price.BookId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.Property(price => price.BookId)
                   .HasColumnName("LinkedBook")
                   .IsRequired(true);

            builder.Property(price => price.Value)
                   .HasColumnName("Price")
                   .IsRequired(true);
        }
    }
}