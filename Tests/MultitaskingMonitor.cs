using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests
{
    public class MultitaskingMonitor
    {
        private List<Exception> OccuredException = null;
        public void WaitAll(Task[] tasks, CancellationToken token)
        {
            var cancellationToken = CancellationTokenSource.CreateLinkedTokenSource(token);
            IEnumerable<Task> proxyTasks = CreateProxy(tasks, cancellationToken);
            try
            {
                Task.WaitAll(proxyTasks.ToArray(), cancellationToken.Token);
            }
            catch (Exception ex)
            {
                if (OccuredException != null)
                {
                    throw OccuredException.First();
                }
                else
                {
                    throw ex;
                }
            }
        }

        private IEnumerable<Task> CreateProxy(Task[] tasks, CancellationTokenSource cancellationToken)
        {
            return tasks.Select(task =>
                task.ContinueWith(t =>
                {
                    if (t.IsFaulted)
                    {
                        if (this.OccuredException == null)
                        {
                            this.OccuredException = new List<Exception>();
                        }
                        this.OccuredException.Add(t.Exception);
                        cancellationToken.Cancel();
                    }
                    return t;
                },
                cancellationToken.Token,
                TaskContinuationOptions.ExecuteSynchronously,
                TaskScheduler.Current).Unwrap());
        }
    }
    
}
