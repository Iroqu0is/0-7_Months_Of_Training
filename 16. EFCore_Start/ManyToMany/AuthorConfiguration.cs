namespace ManyToMany
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Authors");
            builder.HasKey(author => author.Id);

            builder.Property(author => author.Id)
                   .HasColumnName("Id")
                   .IsRequired(true);

            builder.Property(author => author.Name)
                   .HasColumnName("Name")
                   .HasMaxLength(200)
                   .IsRequired(true);
        }
    }
}