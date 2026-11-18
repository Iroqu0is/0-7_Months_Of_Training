namespace BookShop
{
    public static class BookShopTools
    {
        public static async Task<bool> ResetAsync(this DbContext context, CancellationToken token = default)
        {
            if (context is null) throw new ArgumentNullException(nameof(context));
            await context.Database.EnsureDeletedAsync(token);
            return await context.Database.EnsureCreatedAsync(token);
        }
        public static Book CreateBook(string title, ulong code, decimal price, string? description = null)
        {
            if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException($"{nameof(title)} is null or whitespace");
            if (price < 0) throw new ArgumentException($"{nameof(price)} below zero");
            return new Book()
            {
                Name = title,
                Code = new Code() { Value = code },
                Price = new Price() { Value = price },
                Description = new Description() { Text = description }
            };
        }
        public static Author CreateAuthor(string name, string? description = null)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException($"{nameof(name)} is null or whitespace");
            return new Author()
            {
                Name = name,
                Description = new Description() { Text = description }
            };
        }
        public static Publisher CreatePublisher(string name, string? description = null)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException($"{nameof(name)} is null or whitespace");
            return new Publisher()
            {
                Name = name,
                Description = new Description() { Text = description }
            };
        }
        public static BookAuthor SetBinding(Book book, Author author)
        {
            if (book is null) throw new ArgumentNullException(nameof(book));
            if (author is null) throw new ArgumentNullException(nameof(author));
            return new BookAuthor()
            {
                Book = book,
                Author = author
            };
        }
    }
}