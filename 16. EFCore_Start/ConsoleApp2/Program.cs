global using System.Diagnostics;
global using System.Reflection;
global using System.Text;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.EntityFrameworkCore.SqlServer;

namespace ConsoleApp2
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var timer = Stopwatch.StartNew();
            using var controller = new CancellationTokenSource(8000);
            using var context = new Context();
            var tracker = controller.Token;
            //await context.Reset();// для тестов
            if (await context.Database.CanConnectAsync(tracker))
            {
                Console.WriteLine("Connection state: Open\n");

            }
            timer.Stop();
            Console.WriteLine($"\nMethod 'Main' stopped in {timer.ElapsedMilliseconds} ms");
        }
    }
}