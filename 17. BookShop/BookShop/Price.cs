namespace BookShop
{
    public class Price
    {
        public decimal Value { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; } = null!;

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}