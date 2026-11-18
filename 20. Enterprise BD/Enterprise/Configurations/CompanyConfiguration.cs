namespace Enterprise.Configurations
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Companies");
            builder.HasKey(c => c.Id);
            builder.HasIndex(c => c.Name);

            builder.ComplexProperty(c => c.Address, AddressConfiguration.Configure);
            builder.ComplexProperty(c => c.Description, DescriptionOtherConfiguration.Configure);

            builder.Property(c => c.Id)
                   .HasColumnName("Id");

            builder.Property(c => c.Name)
                   .HasColumnName("Name")
                   .HasMaxLength(100);
        }
    }
}