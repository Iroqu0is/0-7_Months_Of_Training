global using System.Diagnostics;
global using System.Reflection;
global using Enterprise.Configurations;
global using Enterprise.Entities;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.EntityFrameworkCore.SqlServer;

namespace Enterprise
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            using var controller = new CancellationTokenSource(8000);
            using var context = new Context();
            var tracker = controller.Token;
            var timer = Stopwatch.StartNew();
            try
            {
                await context.ResetAsync(tracker);
                if (await context.Database.CanConnectAsync(tracker))
                {
                    Console.WriteLine("Connection state: Open\n");
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
                Console.WriteLine($"\nWorktime: {timer.ElapsedMilliseconds} ms.");
            }
        }
    }
}