namespace OwnedTable
{
    public class DescriptionConfiguration
    {
        public static void Configure(OwnedNavigationBuilder<Book, Description> builder)
        {
            builder.Property(desc => desc.Text)
                   .HasColumnName("Description")
                   .HasMaxLength(1024)
                   .IsRequired(true);
        }
    }
}