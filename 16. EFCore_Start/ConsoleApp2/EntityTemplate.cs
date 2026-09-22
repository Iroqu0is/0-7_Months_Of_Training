namespace ConsoleApp2
{
    public abstract class EntityTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public override string ToString()
        {
            return Name;
        }
    }
}