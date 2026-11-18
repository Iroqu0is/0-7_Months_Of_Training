namespace Enterprise.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Name);

            builder.ComplexProperty(e => e.Address, AddressConfiguration.Configure);
            builder.ComplexProperty(e => e.Description, DescriptionAboutEmployeeConfiguration.Configure);

            builder.HasOne(e => e.Company)
                   .WithMany(c => c.Employees)
                   .HasForeignKey(e => e.CompanyId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(e => e.Position)
                   .WithMany(p => p.Employees)
                   .HasForeignKey(e => e.PositionId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.Property(e => e.Id)
                   .HasColumnName("Id");

            builder.Property(e => e.Name)
                   .HasColumnName("Name")
                   .HasMaxLength(100);
        }
    }
}