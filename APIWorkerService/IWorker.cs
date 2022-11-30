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
        Task AddStudents_BK_Worker_Process(CancellationToken cancellationToken);
        Task AddStudentsCompleted(CancellationToken cancellationToken);        
    }
}