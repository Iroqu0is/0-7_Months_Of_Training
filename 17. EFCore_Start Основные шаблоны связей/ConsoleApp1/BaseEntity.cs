namespace ConsoleApp1
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public override string ToString()
        {
            return Name;
        }
    }
}