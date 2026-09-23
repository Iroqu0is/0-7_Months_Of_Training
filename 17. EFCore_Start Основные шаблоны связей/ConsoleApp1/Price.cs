namespace ConsoleApp1
{
    public class Price
    {
        public int Value { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; } = null!;

        public override string ToString()
        {
            return $"{Value}";
        }
    }
}