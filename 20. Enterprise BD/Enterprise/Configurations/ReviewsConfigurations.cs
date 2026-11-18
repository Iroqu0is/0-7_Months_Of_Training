namespace Enterprise.Configurations
{
    public class ReviewsConfigurations : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.ToTable("Reviews");
            builder.HasKey(r => r.Id);

            builder.HasOne(r => r.Company)
                   .WithMany(c => c.Reviews)
                   .HasForeignKey(r => r.CompanyId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.Property(r => r.Id)
                   .HasColumnName("Id");

            builder.Property(r => r.CompanyId)
                   .HasColumnName("CompanyId");

            builder.Property(r => r.Text)
                   .HasColumnName("Review")
                   .HasMaxLength(200);
        }
    }
}