namespace Enterprise.Configurations
{
    public class AddressConfiguration
    {
        public static void Configure(ComplexPropertyBuilder<Address> builder)
        {
            builder.Property(a => a.Text)
                   .HasColumnName("Address")
                   .HasDefaultValue("No data")
                   .HasMaxLength(200);
        }
    }
}