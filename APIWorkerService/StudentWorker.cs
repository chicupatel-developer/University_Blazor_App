using DataAccess.Contracts;
using DataAccess.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace APIWorkerService
{
    public class StudentWorker : IStudentWorker
    {
        readonly ILogger<StudentWorker> _logger;
        readonly IStudentService studentService;

        public StudentWorker(ILogger<StudentWorker> logger, IStudentService studentService)
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

            int count = 1;

            // while (!cancellationToken.IsCancellationRequested)
            // while (!flag)
            while (count<=10)
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
                    await Task.Delay(3 * 1000);
                    // flag = true;
                    count++;
                }
                else
                {
                    // flag = true;

                    // something goes wrong @ student-service, then stop adding
                    // further student @ db and return back from
                    // AddStudent async task here
                    count = 11;
                }                
            }
        }


        public async Task Generate_CSV_Students_File_BK_Worker_Process(CancellationToken cancellationToken)
        {
            // bool flag = cancellationToken.IsCancellationRequested;

            int count = 1;

            string fileName = @"C:\BlazorApps\BlazorServerApp\TXT_Files\Students.txt";
                    
            try
            {     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                using (FileStream fs = File.Create(fileName))
                {
                    while (count <= 10)
                    {
                        Byte[] student = new UTF8Encoding(true).GetBytes(count+ ":Student"+ count+ "-FirstName:Student"+count+"-LastName");
                        fs.Write(student, 0, student.Length);

                        await Task.Delay(1 * 1000);
                        count++;
                    }                 
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
