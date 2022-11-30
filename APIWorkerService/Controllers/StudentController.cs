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

        private readonly StudentDBWorkerService _workerDbService;
        private readonly StudentCSVFileWorkerService _workerCsvFileService;
        private readonly IStudentService _studentService;

        public StudentController(
          ILogger<StudentController> logger,
          StudentDBWorkerService _workerDbService,
          StudentCSVFileWorkerService _workerCsvFileService,
          IStudentService studentService)
        {
            _logger = logger;
            this._workerDbService = _workerDbService;
            this._workerCsvFileService = _workerCsvFileService;
            _studentService = studentService;
        }

        // add 10 students to csv file via background-worker-process
        [HttpGet]
        [Route("add_students_to_csv_file")]
        public async Task<IActionResult> Add_Students_To_CSV_File_BK_Worker_Process()
        {
            BKProcessResponse response = new BKProcessResponse();

            await _workerCsvFileService.StartAsync(HttpContext.RequestAborted);
            response.Response = "BackGround Worker Process Done Successfully! Students Added To CSV File Successfully!";

            return Ok(response);

        }

        // add 10 students to db via background-worker-process
        [HttpGet]
        [Route("add_students_to_db")]
        public async Task<IActionResult> Add_Students_To_DB_BK_Worker_Process()
        {
            BKProcessResponse response = new BKProcessResponse();

            await _workerDbService.StartAsync(HttpContext.RequestAborted);
            response.Response = "BackGround Worker Process Done Successfully! Students Added To Database Successfully!";

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
