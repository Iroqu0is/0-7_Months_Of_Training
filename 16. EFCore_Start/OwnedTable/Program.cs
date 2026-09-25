global using System.Diagnostics;
global using System.Reflection;
global using System.Text;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.EntityFrameworkCore.SqlServer;

namespace OwnedTable
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
                if (await context.Database.CanConnectAsync(tracker))
                {
                    Console.WriteLine("Connection state: Open");
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