namespace ManyToMany
{
    public class DescriptionConfiguration
    {
        public static void Configure(OwnedNavigationBuilder<BookAuthors, Description> builder)
        {
            builder.Property(description => description.Text)
                   .HasColumnName("Description")
                   .IsRequired(true);
        }
    }
}