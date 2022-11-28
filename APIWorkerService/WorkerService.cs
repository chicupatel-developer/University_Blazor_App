﻿using Microsoft.Extensions.Hosting;
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

        // private int number = 0;

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            // await worker.DoWork(cancellationToken);

            await worker.AddStudent(cancellationToken);

            /*
            while (!cancellationToken.IsCancellationRequested)
            {
                Interlocked.Increment(ref number);
                Console.WriteLine("now the number is :", number);
                await Task.Delay(2 * 1000);
            }
            */
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await worker.AddStudentCompleted(cancellationToken);
        }    
    }
}
