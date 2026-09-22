namespace ConsoleApp2
{
    public class EmployeeConfiguration : EntityTemlateConfiguration<Employee>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            base.Configure(builder);

            builder.HasOne(employee => employee.Position)
                   .WithMany(position => position.Employees)
                   .HasForeignKey(employee => employee.PositionId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(employee => employee.Company)
                   .WithMany(company => company.Employees)
                   .HasForeignKey(employee => employee.CompanyId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.OwnsOne(employee => employee.PersonalData, PersonalDataConfiguration.Configure);

            builder.Property(employee => employee.PositionId)
                   .HasColumnName("Positions_Code")
                   .IsRequired(true);

            builder.Property(employee => employee.CompanyId)
                   .HasColumnName("Companies_Code")
                   .IsRequired(true);
        }
    }
}