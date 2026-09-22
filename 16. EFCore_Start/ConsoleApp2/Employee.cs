namespace ConsoleApp2
{
    public class Employee : EntityTemplate
    {
        public int PositionId { get; set; }
        public Position Position { get; set; } = null!;

        public int CompanyId { get; set; }
        public Company Company { get; set; } = null!;

        public PersonalData? PersonalData { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}