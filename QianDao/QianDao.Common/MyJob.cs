using Quartz;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class MyJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            //context.Trigger.JobDataMap
            return Task.Run(() =>
            {
                Console.WriteLine("Job Start");
            });
        }
        
    }
}
