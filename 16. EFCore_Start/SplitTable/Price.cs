namespace SplitTable
{
    public class Price
    {
        public int Id { get; set; }
        public int Value { get; set; }

        public Book Book { get; set; } = null!;

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}