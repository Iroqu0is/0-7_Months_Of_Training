namespace BookShop.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            builder.HasKey(b => b.Id);
            builder.HasIndex(b => b.Name);

            builder.ComplexProperty(b => b.Description, DescriptionForBookConfiguration.Configure);

            builder.HasOne(b => b.Publisher)
                   .WithMany(p => p.Books)
                   .HasForeignKey(b => b.PublisherId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.Property(b => b.Id)
                   .HasColumnName("Id");

            builder.Property(b => b.Name)
                   .HasColumnName("Title")
                   .HasMaxLength(100);
        }
    }
}