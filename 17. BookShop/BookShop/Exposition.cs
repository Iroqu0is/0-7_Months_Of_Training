namespace BookShop
{
    public class Exposition : Description
    {
        public int BookId { get; set; }
        public Book Book { get; set; } = null!;
    }
}
