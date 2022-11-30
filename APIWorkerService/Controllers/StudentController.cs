using DataAccess.Contracts;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DataAccess.DTO;

namespace APIWorkerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;

        private readonly WorkerService _workerService;
        private readonly IStudentService _studentService;

        public StudentController(
          ILogger<StudentController> logger,
          WorkerService workerService,
          IStudentService studentService)
        {
            _logger = logger;
            _workerService = workerService;
            _studentService = studentService;
        }

        [HttpGet]
        [Route("addstudents")]
        public async Task<IActionResult> AddStudents_BK_Worker_Process()
        {
            BKProcessResponse response = new BKProcessResponse();

            await _workerService.StartAsync(HttpContext.RequestAborted);
            response.Response = "BackGround Worker Process Done Successfully! Students Added Successfully!";

            return Ok(response);
            
        }

        [HttpGet]
        [Route("getstudents")]
        // public IActionResult GetStudents()
        // public async Task<List<Student>> GetStudents()
        public async Task<IActionResult> GetStudents()
        {
            // return await _studentService.GetStudents();          
            return Ok(await _studentService.GetStudents());
        }
    }
}
