using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using QianDao.WebAPI.Job;
using QianDao.WebAPI.Util;
using Quartz;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QianDao.WebAPI
{
    public class MyJob : IJob
    {

        public Task Execute(IJobExecutionContext context)
        {
            var jobData= context.JobDetail.JobDataMap;
            var uname= jobData.GetString("uname");
            var upwd = jobData.GetString("upwd");
            var count= jobData.GetIntValue("count");

            return Task.Run(() =>
            {
                try
                {
                    RewardTask rt = new RewardTask();
                    if (count>0)
                    {
                        rt.JNGAReword(uname, upwd);
                    }
                }
                catch (Exception e)
                {
                    JobExecutionException e2 = new JobExecutionException(e);
                    e2.RefireImmediately = true;
                    jobData.Put("count", count-1);
                    throw e2;
                }
               
            });
        }
        
    }
}
