using System.Threading;
using System.Threading.Tasks;

namespace APIWorkerService
{
    public interface IWorker
    {
        Task DoWork(CancellationToken cancellationToken);
    }
}