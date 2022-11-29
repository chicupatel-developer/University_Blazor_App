using DataAccess.Models;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace APIWorkerService
{
    public class WorkerService : IHostedService
    {
        private readonly IWorker worker;

        public WorkerService(IWorker worker)
        {
            this.worker = worker;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await worker.AddStudent(cancellationToken);       
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await worker.AddStudentCompleted(cancellationToken);
        }    
    }
}
