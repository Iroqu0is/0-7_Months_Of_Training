namespace OwnedTable
{
    public class Description
    {
        public string? Text { get; set; }

        public override string ToString()
        {
            return Text ?? string.Empty;
        }
    }
}