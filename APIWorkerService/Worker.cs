using DataAccess.Contracts;
using DataAccess.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace APIWorkerService
{
    public class Worker : IWorker
    {
        readonly ILogger<Worker> _logger;
        readonly IStudentService studentService;

        private int number = 0;
        public Worker(ILogger<Worker> logger, IStudentService studentService)
        {
            _logger = logger;
            this.studentService = studentService;
        }

        public async Task DoWork(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {                
                Interlocked.Increment(ref number);
                _logger.LogInformation("now the number is : {number}", number);
                await Task.Delay(2 * 1000);
            }
        }

        public async Task AddStudent(CancellationToken cancellationToken)
        {
            bool flag = cancellationToken.IsCancellationRequested;

            // while (!cancellationToken.IsCancellationRequested)
            while (!flag)
            {
                if(studentService.AddStudent(new Student()
                { 
                     Email = "student-11@gmail.com",
                      FirstName="student-11-firstname",
                       LastName = "student-11-lastname",
                        PhoneNumber = "123-456-7890"
                }))
                {
                    _logger.LogInformation("now the number is : {number}", number);
                    await Task.Delay(2 * 1000);
                    flag = true;
                }
                else
                {
                    flag = true;
                }                
            }
        }
     
    }
}
