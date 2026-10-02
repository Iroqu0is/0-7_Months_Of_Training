namespace BookShop
{
    public class DescriptionConfiguration
    {
        public static void Configure(OwnedNavigationBuilder<BookAuthors, Description> builder)
        {
            builder.Property(d => d.Text)
                   .HasColumnName("Description")
                   .HasMaxLength(2048)
                   .HasDefaultValue("Empty")
                   .IsRequired(true);
        }
    }
}