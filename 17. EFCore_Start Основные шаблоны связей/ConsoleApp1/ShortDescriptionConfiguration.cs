namespace ConsoleApp1
{
    public class ShortDescriptionConfiguration
    {
        public static void Configure(OwnedNavigationBuilder<Book, ShortDescription> builder)
        {
            builder.Property(sd => sd.Description)
                   .HasColumnName("Description")
                   .HasMaxLength(500)
                   .IsRequired(false);
        }
    }
}