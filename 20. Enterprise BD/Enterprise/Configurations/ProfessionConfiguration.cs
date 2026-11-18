namespace Enterprise.Configurations
{
    public class ProfessionConfiguration : IEntityTypeConfiguration<Profession>
    {
        public void Configure(EntityTypeBuilder<Profession> builder)
        {
            builder.ToTable("Professions");
            builder.HasKey(p => p.Id);
            builder.HasIndex(p => p.Name);

            builder.Property(p => p.Id)
                   .HasColumnName("Id");

            builder.Property(p => p.Name)
                   .HasColumnName("Profession")
                   .HasMaxLength(100);
        }
    }
}