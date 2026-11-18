namespace Enterprise.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string Text { get; set; } = null!;

        public int CompanyId { get; set; }
        public Company Company { get; set; } = null!;
    }
}