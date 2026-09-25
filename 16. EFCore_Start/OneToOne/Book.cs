namespace OneToOne
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public Price Price { get; set; } = null!;

        public override string ToString()
        {
            return Name;
        }
    }
}