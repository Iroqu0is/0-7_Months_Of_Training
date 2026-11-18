namespace BookShop.Entities
{
    public class Code
    {
        public ulong Value { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; } = null!;
    }
}
