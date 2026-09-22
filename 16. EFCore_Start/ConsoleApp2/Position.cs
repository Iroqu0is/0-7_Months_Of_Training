namespace ConsoleApp2
{
    public class Position : EntityTemplate
    {
        public ICollection<Employee> Employees { get; set; } = [];

        public override string ToString()
        {
            return base.ToString();
        }
    }
}