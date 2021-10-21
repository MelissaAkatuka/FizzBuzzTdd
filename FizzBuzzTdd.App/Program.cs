using System.Threading;
using System.Threading.Tasks;
using FizzBuzzTdd.Domain;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FizzBuzzTdd.App
{
    public class Program
    {
        private static readonly CancellationTokenSource tokenSource = new();
        static Task Main(string[] args)
        {
            var hostBuilder = Host.CreateDefaultBuilder(args);
            hostBuilder.ConfigureServices((_, services) =>
            {                
                services.AddTransient<FizzBuzz>();
                services.AddHostedService<Startup>();
                services.AddSingleton(tokenSource);
            });

            using var host = hostBuilder.Build();

            return host.RunAsync(tokenSource.Token);
        }
    }
}
