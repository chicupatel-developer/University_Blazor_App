using System.Threading;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Models;
using DataAccess.DTO;
using DataAccess.Services;
using DataAccess.Contracts;
using System.Collections.Generic;

namespace APIWorkerService
{
    public interface IWorker
    {      
        Task AddStudent(CancellationToken cancellationToken);
        Task AddStudentCompleted(CancellationToken cancellationToken);
        Task<List<Student>> GetAllStudents(CancellationToken cancellationToken);
    }
}