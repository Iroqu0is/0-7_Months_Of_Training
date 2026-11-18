namespace Enterprise.Configurations
{
    public class PositionInCompanyConfiguration : IEntityTypeConfiguration<PositionInCompany>
    {
        public void Configure(EntityTypeBuilder<PositionInCompany> builder)
        {
            builder.ToTable("PositionInCompanys");
            builder.HasKey(p => p.Id);
            builder.HasIndex(p => p.Name);

            builder.Property(p => p.Id)
                   .HasColumnName("Id");

            builder.Property(p => p.Name)
                   .HasColumnName("Position")
                   .HasMaxLength(100);
        }
    }
}