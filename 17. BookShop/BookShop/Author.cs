namespace BookShop
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<BookAuthors> BookAuthors { get; set; } = [];

        public override string ToString()
        {
            return Name;
        }
    }
}