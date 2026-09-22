namespace ConsoleApp2
{
    public class Company : EntityTemplate
    {
        public ICollection<Employee> Employees { get; set; } = [];

        public Address? Address { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}