namespace BookShop
{
    public class ExpositionConfiguration : IEntityTypeConfiguration<Exposition>
    {
        public void Configure(EntityTypeBuilder<Exposition> builder)
        {
            builder.ToTable("Books");
            builder.HasKey(e => e.BookId);

            builder.HasOne(e => e.Book)
                   .WithOne(b => b.Exposition)
                   .HasForeignKey<Exposition>(e => e.BookId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.Property(e => e.BookId)
                   .ValueGeneratedNever()
                   .IsRequired(true);

            builder.Property(e => e.Text)
                   .HasColumnName("Exposition")
                   .HasDefaultValue("Empty")
                   .HasMaxLength(1024)
                   .IsRequired(true);
        }
    }
}