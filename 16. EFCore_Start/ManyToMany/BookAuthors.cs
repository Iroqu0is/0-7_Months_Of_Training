namespace ManyToMany
{
    public class BookAuthors
    {
        public int BookId { get; set; }
        public Book Book { get; set; } = null!;

        public Description? Description { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;
    }
}