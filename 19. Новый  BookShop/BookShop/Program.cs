global using System.Diagnostics;
global using System.Reflection;
global using BookShop.Configurations;
global using BookShop.Entities;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.EntityFrameworkCore.SqlServer;

namespace BookShop
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var timer = Stopwatch.StartNew();
            using var controller = new CancellationTokenSource(8000);
            using var context = new Context();
            var token = controller.Token;
            try
            {
                //await context.Database.MigrateAsync(token);
                await context.ResetAsync(token);
                if (await context.Database.CanConnectAsync(token))
                {
                    Console.WriteLine("Connection state: Open\n");

                    var book_ThreePigs = BookShopTools.CreateBook("Three Pigs", 123456, 2.4M, "About pigs");

                    var author_Gomer = BookShopTools.CreateAuthor("Gomer", "not Simpson");
                    var author_Shekspir = BookShopTools.CreateAuthor("Shekspir");
                    context.Authors.AddRange(author_Gomer, author_Shekspir);

                    var publidher_EKSMO = BookShopTools.CreatePublisher("EKRRMO", "new publisher");
                    context.Publishers.Add(publidher_EKSMO);

                    var binding_ThreePigs_Gomer = BookShopTools.SetBinding(book_ThreePigs, author_Gomer);
                    var binding_ThreePigs_Shekspir = BookShopTools.SetBinding(book_ThreePigs, author_Shekspir);
                    context.BookAuthors.AddRange(binding_ThreePigs_Gomer, binding_ThreePigs_Shekspir);

                    book_ThreePigs.Reviews.Add(new Review() { Text = "Good book" });
                    book_ThreePigs.Reviews.Add(new Review() { Text = "LOL" });
                    book_ThreePigs.Publisher = publidher_EKSMO;
                    context.Books.Add(book_ThreePigs);

                    await context.SaveChangesAsync(token);
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