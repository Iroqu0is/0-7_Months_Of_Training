namespace Enterprise.Configurations
{
    public class DescriptionAboutEmployeeConfiguration
    {
        public static void Configure(ComplexPropertyBuilder<Description> builder)
        {
            builder.Property(d => d.Text)
                   .HasColumnName("AboutEmployee")
                   .HasMaxLength(2000)
                   .HasDefaultValue("No data");
        }
    }
}