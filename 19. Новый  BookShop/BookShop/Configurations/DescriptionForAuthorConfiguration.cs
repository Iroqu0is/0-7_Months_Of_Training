namespace BookShop.Configurations
{
    public class DescriptionForAuthorConfiguration
    {
        public static void Configure(ComplexPropertyBuilder<Description> builder)
        {
            builder.Property(db => db.Text)
                   .HasColumnName("AboutAuthor")
                   .HasMaxLength(2000);
        }
    }
}