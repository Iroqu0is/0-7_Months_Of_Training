namespace BookShop.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public Description Description { get; set; } = null!;

        public ICollection<BookAuthor> BookAuthor { get; set; } = [];
    }
}