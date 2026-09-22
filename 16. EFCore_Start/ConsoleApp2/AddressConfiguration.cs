namespace ConsoleApp2
{
    public class AddressConfiguration
    {
        public static void Configure(OwnedNavigationBuilder<Company, Address> builder)
        {
            builder.Property(at => at.CountryCode)
                   .HasColumnName("Country_Code")
                   .HasMaxLength(16)
                   .IsRequired(false);

            builder.Property(at => at.Country)
                   .HasColumnName("Country")
                   .HasMaxLength(128)
                   .IsRequired(false);

            builder.Property(at => at.Region)
                   .HasColumnName("Region")
                   .HasMaxLength(128)
                   .IsRequired(false);

            builder.Property(at => at.City)
                   .HasColumnName("City")
                   .HasMaxLength(128)
                   .IsRequired(false);

            builder.Property(at => at.Locality)
                   .HasColumnName("Locality")
                   .HasMaxLength(128)
                   .IsRequired(false);

            builder.Property(at => at.PostalCode)
                   .HasColumnName("Postal_Code")
                   .HasMaxLength(16)
                   .IsRequired(false);

            builder.Property(at => at.Street)
                   .HasColumnName("Street")
                   .HasMaxLength(128)
                   .IsRequired(false);

            builder.Property(at => at.Building)
                   .HasColumnName("Building")
                   .HasMaxLength(8)
                   .IsRequired(false);

            builder.Property(at => at.RoomOrOffice)
                   .HasColumnName("RoomOrOffice")
                   .HasMaxLength(8)
                   .IsRequired(false);
        }
    }
}