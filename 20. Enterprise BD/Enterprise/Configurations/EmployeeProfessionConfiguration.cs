namespace Enterprise.Configurations
{
    public class EmployeeProfessionConfiguration : IEntityTypeConfiguration<EmployeeProfession>
    {
        public void Configure(EntityTypeBuilder<EmployeeProfession> builder)
        {
            builder.ToTable("EmployeeProfession");
            builder.HasKey(ep => new { ep.EmployeeId, ep.ProfessionId });

            builder.HasOne(ep => ep.Employee)
                   .WithMany(e => e.EmployeeProfessions)
                   .HasForeignKey(ep => ep.EmployeeId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ep => ep.Profession)
                   .WithMany(p => p.EmployeeProfessions)
                   .HasForeignKey(ep => ep.ProfessionId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.Property(ep => ep.EmployeeId)
                   .HasColumnName("EmployeeId");

            builder.Property(ep => ep.ProfessionId)
                   .HasColumnName("ProfessionId");
        }
    }
}