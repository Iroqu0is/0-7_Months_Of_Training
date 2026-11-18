namespace BookShop.Configurations
{
    public class DescriptionForBookConfiguration
    {
        public static void Configure(ComplexPropertyBuilder<Description> builder)
        {
            builder.Property(db => db.Text)
                   .HasColumnName("Description")
                   .HasMaxLength(2000);
        }
    }
}