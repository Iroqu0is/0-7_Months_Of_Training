namespace BookShop.Entities
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public Description Description { get; set; } = null!;

        public ICollection<Book> Books { get; set; } = [];
    }
}