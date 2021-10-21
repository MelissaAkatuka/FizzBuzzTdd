using FizzBuzzTdd.Domain;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FizzBuzzTdd.App
{
    public class Startup : IHostedService
    {
        private readonly FizzBuzz _fb;
        private readonly CancellationTokenSource _cancellationTokenSource;

        public Startup(FizzBuzz fb, CancellationTokenSource cancellationTokenSource)
        {
            _fb = fb;
            _cancellationTokenSource = cancellationTokenSource;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Resultado: {_fb.GetValue(i)}");
            }            

            _cancellationTokenSource.Cancel();
            return;
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Parando a aplicação...");
            return;
        }
    }
}
