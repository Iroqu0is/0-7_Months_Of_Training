namespace BookShop
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id)
                   .HasColumnName("Id")
                   .IsRequired(true);

            builder.Property(b => b.Title)
                   .HasColumnName("Title")
                   .HasMaxLength(200)
                   .IsRequired(true);
        }
    }
}