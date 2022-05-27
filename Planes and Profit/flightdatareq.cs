
using System;
using Microsoft.Extensions.Hosting;


namespace HelloWorld
{
    public class FlightData : BackgroundService
    {
        private HttpClient client;
        private readonly string url = "https://opensky-network.org/api/states/all";


        public override Task StartAsync(CancellationToken cancellationToken)
        {
            return base.StartAsync(cancellationToken);  
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            return base.StopAsync(cancellationToken);
        }


        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var response = await client.GetAsync(url);
                Console.WriteLine(response);
            }
        }



    }
}