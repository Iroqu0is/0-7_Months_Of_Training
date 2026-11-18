namespace BookShop.Configurations
{
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.ToTable("Publishers");
            builder.HasKey(p => p.Id);
            builder.HasIndex(p => p.Name);

            builder.ComplexProperty(p => p.Description, DescriptionForPublisherConfiguration.Configure);

            builder.Property(p => p.Id)
                   .HasColumnName("Id");

            builder.Property(p => p.Name)
                   .HasColumnName("Publisher")
                   .HasMaxLength(100);
        }
    }
}