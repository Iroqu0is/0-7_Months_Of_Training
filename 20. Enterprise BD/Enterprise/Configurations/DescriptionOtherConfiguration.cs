namespace Enterprise.Configurations
{
    public class DescriptionOtherConfiguration
    {
        public static void Configure(ComplexPropertyBuilder<Description> builder)
        {
            builder.Property(d => d.Text)
                   .HasColumnName("Description")
                   .HasMaxLength(2000)
                   .HasDefaultValue("No data");
        }
    }
}