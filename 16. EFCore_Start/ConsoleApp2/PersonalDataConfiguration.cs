namespace ConsoleApp2
{
    public class PersonalDataConfiguration
    {
        public static void Configure(OwnedNavigationBuilder<Employee, PersonalData> builder)
        {
            builder.Property(pd => pd.Series)
                   .HasColumnName("Passport_Series")
                   .HasMaxLength(2)
                   .IsRequired(true);

            builder.Property(pd => pd.SerialNumber)
                   .HasColumnName("Passport_Number")
                   .IsRequired(true);

            builder.Property(pd => pd.Email)
                   .HasColumnName("Email")
                   .HasMaxLength(32)
                   .IsRequired(false);

            builder.Property(pd => pd.Phone)
                   .HasColumnName("Phone")
                   .HasMaxLength(32)
                   .IsRequired(false);

            builder.Property(pd => pd.Additional)
                   .HasColumnName("Additional")
                   .HasMaxLength(512)
                   .IsRequired(false);
        }
    }
}