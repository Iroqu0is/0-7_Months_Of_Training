global using System.Diagnostics;
global using System.Reflection;
global using System.Text;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.EntityFrameworkCore.SqlServer;
global using Microsoft.Extensions.Logging;

namespace BookShop
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var timer = Stopwatch.StartNew();
            using var controller = new CancellationTokenSource(6000);
            var tracker = controller.Token;
            using (var context = new Context())
            {
                try
                {
                    await context.Database.MigrateAsync(tracker);
                    if (await context.Database.CanConnectAsync(tracker))
                    {
                        Console.WriteLine("Connection state: Open\n");

                        var author_Gomer = new Author()
                        {
                            Name = "Gomer"
                        };

                        var author_Sheckspir = new Author()
                        {
                            Name = "Sheckspir"
                        };

                        context.Authors.AddRange(author_Gomer, author_Sheckspir);
                        await context.SaveChangesAsync(tracker);

                        var book_ThreePigs = new Book()
                        {
                            Title = "Three Pigs",
                            Price = new Price() { Value = 2.5M },
                            Exposition = new Exposition() { Text = "About pigs" }
                        };

                        book_ThreePigs.Reviews.Add(new Review() { Comment = "Good" });
                        book_ThreePigs.Reviews.Add(new Review() { Comment = "No Good" });
                        book_ThreePigs.Reviews.Add(new Review() { Comment = "LoL" });

                        book_ThreePigs.BookAuthors.Add(new BookAuthors() { BookId = book_ThreePigs.BookId, AuthorId = author_Gomer.AuthorId });
                        book_ThreePigs.BookAuthors.Add(new BookAuthors() { BookId = book_ThreePigs.BookId, AuthorId = author_Sheckspir.AuthorId });

                        context.Books.Add(book_ThreePigs);
                        await context.SaveChangesAsync(tracker);
                    }
                }
                catch (Exception ex)
                {
                    if (ex.InnerException is not null) Console.WriteLine(ex.InnerException.Message);
                    Console.WriteLine(ex.Message);
                }
            }
            timer.Stop();
            Console.WriteLine($"\nMethod 'Main' stopped in {timer.ElapsedMilliseconds} ms.");
        }
    }
}