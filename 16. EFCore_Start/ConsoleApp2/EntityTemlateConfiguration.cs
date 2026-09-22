namespace ConsoleApp2
{
    public abstract class EntityTemlateConfiguration<T> : IEntityTypeConfiguration<T> where T : EntityTemplate
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.ToTable(typeof(T).Name);
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                   .HasColumnName("Id")
                   .IsRequired(true);

            builder.Property(e => e.Name)
                   .HasColumnName("Name")
                   .HasMaxLength(200)
                   .IsRequired(true);
        }
    }
}