using System.Threading;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Models;
using DataAccess.DTO;
using DataAccess.Services;
using DataAccess.Contracts;

namespace APIWorkerService
{
    public interface IWorker
    {
        Task DoWork(CancellationToken cancellationToken);

        Task AddStudent(CancellationToken cancellationToken);
    }
}