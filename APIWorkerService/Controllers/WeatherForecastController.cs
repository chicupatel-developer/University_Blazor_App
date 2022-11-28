using DataAccess.Contracts;
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
        private readonly IStudentService _studentService;

        public WeatherForecastController(
          ILogger<WeatherForecastController> logger,
          WorkerService workerService,
          IStudentService studentService)
        {
            _logger = logger;
            _workerService = workerService;
            _studentService = studentService;
        }
     

        [HttpGet]
        [Route("addstudent")]
        public async Task<IActionResult> AddStudent()
        {
            await _workerService.StartAsync(HttpContext.RequestAborted);
            return Ok("Student Added");
        }

        [HttpGet]
        [Route("getstudents")]
        // public async Task<IActionResult> GetStudents()
        public IActionResult GetStudents()
        {

            return Ok(_studentService.GetStudents());

            /*
            await _workerService.StartAsync(HttpContext.RequestAborted);
            return Ok("All Students Got");
            */

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
    }
}
