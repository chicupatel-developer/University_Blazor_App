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

        public Worker(ILogger<Worker> logger, IStudentService studentService)
        {
            _logger = logger;
            this.studentService = studentService;
        }    

        public async Task AddStudentsCompleted(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Add-Students Task Is Completed And Exit From Process!");
            await Task.Delay(2 * 1000);
        }

        public async Task AddStudents_BK_Worker_Process(CancellationToken cancellationToken)
        {
            bool flag = cancellationToken.IsCancellationRequested;

            int count = 21;

            // while (!cancellationToken.IsCancellationRequested)
            // while (!flag)
            while (count<=30)
            {
                if(studentService.AddStudent(new Student()
                { 
                     Email = "student-"+count+"@gmail.com",
                      FirstName="student-"+count+"-firstname",
                       LastName = "student-"+count+"-lastname",
                        PhoneNumber = "123-456-7890"
                }))
                {               
                    _logger.LogInformation("New Student Added To Database Successfully!");
                    await Task.Delay(1 * 1000);
                    // flag = true;
                    count++;
                }
                else
                {
                    // flag = true;

                    // something goes wrong @ student-service, then stop adding
                    // further student @ db and return back from
                    // AddStudent async task here
                    count = 31;
                }                
            }
        }
    }
}
