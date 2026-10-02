namespace BookShop
{
    public class PriceConfiguration : IEntityTypeConfiguration<Price>
    {
        public void Configure(EntityTypeBuilder<Price> builder)
        {
            builder.ToTable("Prices");
            builder.HasKey(p => p.BookId);

            builder.HasOne(p => p.Book)
                   .WithOne(b => b.Price)
                   .HasForeignKey<Price>(p => p.BookId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.Property(p => p.BookId)
                   .HasColumnName("BookId")
                   .ValueGeneratedNever()
                   .IsRequired(true);

            builder.Property(p => p.Value)
                   .HasColumnName("Price")
                   .IsRequired(true);
        }
    }
}