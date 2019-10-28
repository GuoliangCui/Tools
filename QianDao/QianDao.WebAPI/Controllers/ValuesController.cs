using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using NLog;
using NLog.Web;
using QianDao.WebAPI.Util;
using Quartz;
using Quartz.Impl.Matchers;

namespace QianDao.WebAPI.Controllers
{


    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        public static Logger logger = NLogBuilder.ConfigureNLog("Nlog.config").GetCurrentClassLogger();
        private readonly ISchedulerFactory _schedulerFactory;
        private IScheduler _scheduler;
        public ValuesController(ISchedulerFactory schedulerFactory)
        {
            this._schedulerFactory = schedulerFactory;
        }
        // GET api/values
        [HttpGet("/add/task")]
        [HttpGet]
        public async Task<string> Get(string name="cgl")
        {
            logger.Info(name + "请求了");
            var uname = "今天最后签到";
            var upwd = "cuiguoliang";
            //var uname = "崔国亮";
            //var upwd = "cuiguoliang";
            //if (name=="cgl")
            //{
            //    uname = "崔国亮";
            //    upwd = "cuiguoliang";
            //}
           
            _scheduler = await _schedulerFactory.GetScheduler();

            await _scheduler.Start();

           // var trigger = TriggerBuilder.Create().WithCronSchedule("10 21 9 * * ?").Build();
            //var trigger = TriggerBuilder.Create().WithCronSchedule("0/5 * * * * ?").Build();

            var trigger = TriggerBuilder.Create().WithCronSchedule("2 0 0 * * ?").Build();

            var jobName = Guid.NewGuid().ToString();

            GroupMatcher<JobKey> matcher = GroupMatcher<JobKey>.GroupEquals("group0");
            var jobKeys = _scheduler.GetJobKeys(matcher).Result;

            var uJob = jobKeys.FirstOrDefault(u => u.Name == name);

            if (uJob == null)
            {
                var jobDetail = JobBuilder.Create<MyJob>().UsingJobData("uname", uname).UsingJobData("upwd", upwd).UsingJobData("count",10).WithIdentity(name, "group0").Build();

                await _scheduler.ScheduleJob(jobDetail, trigger);
                logger.Info(uname + "签到任务启动:" + DateTime.Now.ToString());
                return await Task.FromResult<string>("任务已启动");
            }
            else {
                return await Task.FromResult<string>("任务已存在");
            }
        }

        [HttpGet("/get/list")]
        public async Task<string> JobList()
        {
            _scheduler = await _schedulerFactory.GetScheduler();

            await _scheduler.Start();

            GroupMatcher<JobKey> matcher = GroupMatcher<JobKey>.GroupEquals("group0");
            var jobKeys = _scheduler.GetJobKeys(matcher).Result;

            var names = "当前签到任务人:";
            foreach (var item in jobKeys)
            {
                names += item.Name + ",";
            }
            return await Task.FromResult<string>(names);
        }
    }
}
