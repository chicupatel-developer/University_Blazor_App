﻿using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

namespace WebAPICore
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        private HttpClient client;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            client = new HttpClient();
            _logger.LogInformation("The service has been started...");
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            client.Dispose();
            _logger.LogInformation("The service has been stopped...");
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                /*
                var result = await client.GetAsync("https://www.google.com");

                if (result.IsSuccessStatusCode)
                {
                    _logger.LogInformation("The website is up. Status code {StatusCode}", result.StatusCode);
                }
                else
                {
                    _logger.LogError("The website is down. Status code {StatusCode}", result.StatusCode);
                }
                */
                _logger.LogTrace("service is doing some work...");
                await Task.Delay(5000, stoppingToken);
            }
        }

        /*
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(5000, stoppingToken);
            }
        }
        */
    }
}
