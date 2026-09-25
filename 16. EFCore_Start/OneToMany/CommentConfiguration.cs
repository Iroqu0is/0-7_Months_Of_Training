namespace OneToMany
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");
            builder.HasKey(comment => comment.Id);

            builder.HasOne(comment => comment.Book)
                   .WithMany(book => book.Comments)
                   .HasForeignKey(comment => comment.BookId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.Property(comment => comment.Id)
                   .HasColumnName("Id")
                   .IsRequired(true);

            builder.Property(comment => comment.Text)
                   .HasColumnName("Review")
                   .HasMaxLength(1024)
                   .IsRequired(true);
        }
    }
}