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
        private int number = 0;
        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
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
    }
}
