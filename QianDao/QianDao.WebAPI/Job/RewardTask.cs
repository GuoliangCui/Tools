using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Web;
using QianDao.WebAPI.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QianDao.WebAPI.Job
{
    public class RewardTask
    {
        public static Logger logger = NLogBuilder.ConfigureNLog("Nlog.config").GetCurrentClassLogger();

        public static Dictionary<string, IRequestCookieCollection> cookieList = new Dictionary<string, IRequestCookieCollection>();

        public void JNGAReword(string uname,string pwd)
        {
            HandCodeHelper helper = new HandCodeHelper();
            IRequestCookieCollection cookie = new RequestCookieCollection();
            var loginState = 0;
            if (!cookieList.ContainsKey(uname))
            {

                loginState = helper.Login(uname, pwd, ref cookie);
                cookieList.Add(uname, cookie);
                //记录日志
                logger.Info("登陆并设置cookie");
            }
            else {
                loginState = 100;
                cookie = cookieList[uname];
                logger.Info("有cookie免登陆");
            }
            if (loginState==100)
            {
                var result = helper.Reward(cookie);
                if (result==1001)
                {
                    logger.Info("cookie过期，重新登陆。");
                    //重新登陆
                    loginState = helper.Login(uname, pwd, ref cookie);
                    cookieList.Remove(uname);
                    cookieList.Add(uname, cookie);
                    //记录日志
                    logger.Info("重新登陆并设置cookie");
                    result = helper.Reward(cookie);
                }
                
                if(result==100)
                {
                    //记录日志
                    logger.Info("签到成功！" + result);
                }
                else {
                    logger.Info("签到失败尝试重试");
                    throw new Exception("签到失败");
                }
               
            }
        }
    }
}
