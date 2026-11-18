namespace BookShop.Configurations
{
    public class DescriptionForPublisherConfiguration
    {
        public static void Configure(ComplexPropertyBuilder<Description> builder)
        {
            builder.Property(d => d.Text)
                   .HasColumnName("AboutPublisher")
                   .HasMaxLength(2000);
        }
    }
}