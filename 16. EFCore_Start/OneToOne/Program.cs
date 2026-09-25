global using System.Collections;
global using System.Diagnostics;
global using System.Reflection;
global using System.Text;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.EntityFrameworkCore.SqlServer;

namespace OneToOne
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var timer = Stopwatch.StartNew();
            using var controller = new CancellationTokenSource(6000);
            using var context = new Context();
            var tracker = controller.Token;
            try
            {
                await context.Database.MigrateAsync(tracker);
                //await context.ResetAsync(tracker); // это просто для тестов
                if (await context.Database.CanConnectAsync(tracker))
                {
                    Console.WriteLine("Connection state: Open\n");

                    //var selected = await context.Books
                    //                            .AsNoTracking()
                    //                            .Select(b => new { b.Name, b.Price })
                    //                            .ToArrayAsync(tracker);

                    //var selected = await context.Books
                    //                          .AsNoTracking()
                    //                          .Include(book => book.Price)
                    //                          .ToArrayAsync(tracker);

                    //foreach (var book in selected)
                    //{
                    //    Console.WriteLine($"{book.Name} - {book.Price} c.");
                    //}

                    //var book = await context.Books.FirstAsync(book => book.Id == 2);
                    //if (book is not null)
                    //{
                    //    await context.Entry(book).Reference(book => book.Price).LoadAsync(tracker);
                    //    Console.WriteLine($"{book.Name} - {book.Price} c.");
                    //}
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException is not null) Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                timer.Stop();
                Console.WriteLine($"\nMethod 'Main' stopped in {timer.ElapsedMilliseconds} ms.");
            }
        }
    }
}