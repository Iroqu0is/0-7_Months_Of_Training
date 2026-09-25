namespace SplitTable
{
    public class PriceConfiguration : IEntityTypeConfiguration<Price>
    {
        public void Configure(EntityTypeBuilder<Price> builder)
        {
            builder.ToTable("Books");
            builder.HasKey(price => price.Id);

            builder.HasOne(price => price.Book)
                   .WithOne(book => book.Price)
                   .HasForeignKey<Price>(price => price.Id)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.Property(price => price.Id)
                   .HasColumnName("Id")
                   .ValueGeneratedNever()
                   .IsRequired(true);

            builder.Property(price => price.Value)
                   .HasColumnName("Price")
                   .IsRequired(true);
        }
    }
}