using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QianDao.WebAPI.Util
{
    public class HandCodeHelper
    {
        public int Login(string uname,string upwd,ref IRequestCookieCollection cookieCollection)
        {
            string loginUrl = "http://jnga.app1.magcloud.net/mag/user/v1/user/login";

            //var name = Convert.ToBase64String(Encoding.UTF8.GetBytes(uname));
            //var pwd = Convert.ToBase64String(Encoding.UTF8.GetBytes(upwd));

            string postData = string.Format("account={0}&auth=&password={1}", uname,upwd);

            var result = HttpHelper.POST(loginUrl, postData,ref cookieCollection);
            
            return JsonConvert.DeserializeAnonymousType(result, new {success=false,code=0}).code;
        }

        /// <summary>
        /// 签到
        /// </summary>
        /// <param name="cookieCollection"></param>
        /// <returns></returns>
        public int Reward(IRequestCookieCollection cookieCollection)
        {
            string url = "http://jnga.app1.magcloud.net/mag/addon/v1/sign/signReward";
            var result = HttpHelper.GET(url, cookieCollection);
            return JsonConvert.DeserializeAnonymousType(result, new { success = false, code = 0 }).code;
        }
        
    }
}
