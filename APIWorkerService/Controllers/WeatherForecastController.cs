using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace APIWorkerService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        
        private readonly WorkerService _workerService;
        
        public WeatherForecastController(
          ILogger<WeatherForecastController> logger,
          WorkerService workerService)
        {
            _logger = logger;
            _workerService = workerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            await _workerService.StartAsync(HttpContext.RequestAborted);
            return Ok("OK");
        }

        [HttpGet]
        [Route("addstudent")]
        public async Task<IActionResult> AddStudent()
        {
            await _workerService.StartAsync(HttpContext.RequestAborted);
            return Ok("Student Added");
        }

        [HttpGet]
        [Route("gettemps")]
        public IEnumerable<WeatherForecast> AccessTemps()
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
