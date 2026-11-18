namespace Enterprise
{
    public static class Tools
    {
        public static async Task<bool> ResetAsync(this DbContext context, CancellationToken token = default)
        {
            if (context is null) throw new ArgumentNullException(nameof(context));
            await context.Database.EnsureDeletedAsync(token);
            return await context.Database.EnsureCreatedAsync(token);
        }
        public static Company CreateCompany(string name,
                                            string? address = null,
                                            string? description = null)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException(nameof(name));
            return new Company()
            {
                Name = name,
                Address = new Address() { Text = address ?? "No data" },
                Description = new Description() { Text = description ?? "No data" }
            };
        }
        public static Employee CreateEmployee(string name,
                                              Company? company = null,
                                              PositionInCompany? position = null,
                                              string? address = null,
                                              string? description = null)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException(nameof(name));
            return new Employee()
            {
                Name = name,
                Company = company,
                Position = position,
                Address = new Address() { Text = address ?? "No data" },
                Description = new Description() { Text = description ?? "No data" }
            };
        }
    }
}