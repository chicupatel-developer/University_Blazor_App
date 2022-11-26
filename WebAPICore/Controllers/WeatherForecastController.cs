using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkerSrc;
using System.IO;
using WebAPICore;



namespace WebAPICore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public IBackgroundTaskQueue _queue { get; }
        private readonly IServiceScopeFactory _serviceScopeFactory;

        private readonly ILoggerService _loggerService;
        public WeatherForecastController(ILoggerService loggerService, ILogger<WeatherForecastController> logger, IBackgroundTaskQueue queue, IServiceScopeFactory serviceScopeFactory)
        {
            _queue = queue;
            _serviceScopeFactory = serviceScopeFactory;
            _logger = logger;
            _loggerService = loggerService;
        }

        [HttpGet]
        [Route("write")]
        public IActionResult WriteInLog()
        {
            string log = "haha,,,hihi,,,";
            _logger.LogInformation("Connecting api to worker service,,,");

            _loggerService.WriteInLog(log);
            return Ok();
        }



        /*

        [HttpGet]
        public IActionResult Get()
        {
            _queue.QueueBackgroundWorkItem(async token =>
            {
                using (var scope = _serviceScopeFactory.CreateScope())
                {
                    var scopedServices = scope.ServiceProvider;

                    DoWork();

                    await Task.Delay(TimeSpan.FromSeconds(5), token);
                }
            });
            return Ok("In progress..");
        }
        */

        private bool DoWork()
        {
            try
            {
                // throw new Exception();

                string folder = @"C:\BlazorApps\BlazorServerApp\Authers\";
                string fileName = "authers.txt";
                string fullPath = folder + fileName;
                string[] authors = {"Mahesh Chand", "Allen O'Neill", "David McCarter",
                                            "Raj Kumar", "Dhananjay Kumar"};
                System.IO.File.WriteAllLines(fullPath, authors);

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
                

        /*
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        */
    }
}
