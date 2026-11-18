namespace BookShop.Configurations
{
    public class CodeConfiguration : IEntityTypeConfiguration<Code>
    {
        public void Configure(EntityTypeBuilder<Code> builder)
        {
            builder.ToTable("Books");
            builder.HasKey(c => c.BookId);
            builder.HasIndex(c => c.Value).IsUnique();

            builder.HasOne(c => c.Book)
                   .WithOne(b => b.Code)
                   .HasForeignKey<Code>(c => c.BookId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.Property(c => c.Value)
                   .HasColumnName("ISBN");
        }
    }
}