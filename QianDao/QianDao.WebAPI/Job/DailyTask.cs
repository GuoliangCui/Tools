using Microsoft.AspNetCore.Http;
using NLog;
using NLog.Web;
using QianDao.WebAPI.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace QianDao.WebAPI.Job
{
    public class DailyTask
    {
        public static Logger logger = NLogBuilder.ConfigureNLog("Nlog.config").GetCurrentClassLogger();
        private IRequestCookieCollection userCookies = null;

        public DailyTask(string uname, string pwd)
        {
            InitPostData(uname, pwd);
        }

        /// <summary>
        /// 帖子列表
        /// </summary>
        public List<PostInfo> PostList { get; set; }

        public void DianZan()
        {
            var dianZanUrl = "http://jnga.app1.magcloud.net/mag/circle/v1/show/contentAddApplaud";

            Parallel.ForEach<PostInfo>(PostList, item =>
            {
                Thread.Sleep(1000);
                string postData = string.Format("content_id={0}", item.Id);
                HttpHelper.POST(dianZanUrl, postData, userCookies);

            });

            //领奖励
            //var ljlUrl = "https://jnga.app1.magcloud.net/mag/user/v1/GradeScore/getScoreTaskReward?id=86500";
            //HttpHelper.GET(ljlUrl, userCookies);

        }
        public void HuiTie()
        {
            var dianZanUrl = "http://jnga.app1.magcloud.net/mag/circle/v2/show/contentAddComment";
       
            Parallel.For(0, PostList.Count, i =>
            {
                Thread.Sleep(i * 3000);
                var content = huiTieNeiRong();
                string postData = string.Format("auth=&content={0}&content_id={1}&pics=&users=&video=", content, PostList[i].Id);
                var result = HttpHelper.POST(dianZanUrl, postData, userCookies);

            });

            //领奖励
            //var ljlUrl = "https://jnga.app1.magcloud.net/mag/user/v1/GradeScore/getScoreTaskReward?id=86501";
            //HttpHelper.GET(ljlUrl, userCookies);

        }
        private void huiTieTask()
        {

        }
        public void FaTie()
        {

        }

        public void FenXiang()
        {

            var fenXiangUrl = "http://jnga.app1.magcloud.net/mag/user/v1/share/successCallBack";

            Parallel.ForEach<PostInfo>(PostList, item => {
                Thread.Sleep(1000);
                var url = System.Web.HttpUtility.UrlEncode("http://app.jingnanguan.com.cn/mag/circle/v1/show/wapShowView?content_id=" + item.Id + "&themecolor=005ad6");
                string fenXiangFullUrl = string.Format("{0}?title={1}&url={2}", fenXiangUrl, System.Web.HttpUtility.UrlEncode(item.Content), url);
                HttpHelper.GET(fenXiangFullUrl, userCookies);

            });

            //领奖励
            //var ljlUrl = "https://jnga.app1.magcloud.net/mag/user/v1/GradeScore/getScoreTaskReward?id=86502";
            //HttpHelper.GET(ljlUrl, userCookies);
        }

        public void GuanZhu()
        {

            //var guanzhuUrl = "http://jnga.app1.magcloud.net/mag/user/v1/UserRelation/fansAdd";
         

            //Parallel.ForEach<PostInfo>(PostList, item => {
            //    Thread.Sleep(1000);
            //    string fenXiangFullUrl = string.Format("user_id={0}","123123");
            //    HttpHelper.GET(guanzhuUrl, userCookies);
            //});

            //领奖励
            var ljlUrl = "https://jnga.app1.magcloud.net/mag/user/v1/GradeScore/getScoreTaskReward?id=86578";
            HttpHelper.GET(ljlUrl, userCookies);

        }
        
        private void InitPostData(string uname, string pwd)
        {
            HandCodeHelper helper = new HandCodeHelper();
            IRequestCookieCollection cookie = null;
            var loginState = helper.Login(uname, pwd, ref cookie);
            userCookies = cookie;

            var postUrl = "http://jnga.app1.magcloud.net/mag/circle/v2/show/contentNew?p=1&step=20";
            var postData = HttpHelper.GET(postUrl, cookie);

            var result = Newtonsoft.Json.JsonConvert.DeserializeAnonymousType(postData, new { list = new List<PostInfo>() });
            PostList = result.list;
        }

        private string huiTieNeiRong()
        {
            string dataStr = @"看完楼主的帖子，我的心情竟是久久不能平复，正如老子所云：大音希声，大象希形。我现在终于明白我缺乏的是什么了，正是楼主那种对真理的执着追求和楼主那种对理想的艰苦实践所产生的厚重感。面对楼主的帖子，我震惊得几乎不能动弹了，楼主那种裂纸欲出的大手笔，竟使我忍不住一次次的翻开楼主的帖子，每看一次，赞赏之情就激长数分，我总在想，是否有神灵活在它灵秀的外表下，以至能使人三月不知肉味，使人有余音穿梁，三日不绝的感受。楼主，你写得实在是太好了。我唯一能做的，就只有把这个帖子顶上去这件事了,祝大固安越来越好。
&&实在是写得太好了。文笔流畅，修辞得体，深得魏晋诸朝遗风，更将唐风宋骨发扬得入木三分，能在有生之年看见楼主的这个帖子。实在是我三生之幸啊。看完楼主的这个帖子之后，我竟感发生出一种无以名之的悲痛感——啊，这么好的帖子，如果将来我再也看不到了，那我该怎么办？那我该怎么办？直到我毫不犹豫的把楼主的这个帖子转发到了朋友圈。我内心的那种激动才逐渐平复下来。可是我立刻想到，这么好的帖子，倘若别人看不到，那么不是浪费楼主的心血吗？经过痛苦的思想斗争，我终于下定决心，我要把这个帖子分享出去，直到所有人都看到为止
&&在遇到你之前，我对人世间是否有真正的圣人是怀疑的；而现在，我终于相信了！我曾经忘情于汉廷的歌赋，我曾经惊讶于李杜的诗才，我曾经流连于宋元的词曲；但现在，我才知道我有多么浅薄！
&&你的高尚情操太让人感动了。在现在这样一个物欲横流的金钱社会里，竟然还能见到楼主这样的性情中人，无疑是我这辈子最大的幸运。让我深深感受到了人性的伟大。您的帖子，就好比黑暗中刺裂夜空的闪电，又好比撕开乌云的阳光，一瞬间就让我如饮甘露，让我明白了永恒的真理在这个世界上是真实存在着的。只有楼主这样具备广阔胸怀和完整知识体系的人，才能作为这真理的唯一引言者。看完之后，让我陷入了严肃的思考中，我认为，如果不把它分享给固安的好友，就是对真理的一种背叛，就是对谬论的极大妥协。因此，我决定义无返顾的转发了！
&&说的好啊！我在京南固安打滚这么多年，所谓阅人无数，就算没有见过猪走路，也总明白猪肉是啥味道的。一看到您的气势，我就觉得您同在话题区灌水的那帮小混蛋有着本质的差别，那忧郁的语调，那熟悉的签名，还有字里行间高屋建瓴的辞藻。没用的，就算你怎么换马甲都是没有用的，你的亿万拥戴者早已经把你认出来了，你一定就是传说中的最强能手。没想到，没想到，今天可以再睹楼主的风范，我激动得忍不住就在屏幕前流下了眼泪。是啊，只要在您的带领下，京南固安就有希望了。我的内心再一次沸腾了，我胸腔里的血再一次燃烧了。您的几句话虽然简单，却概括扼要，一语道出了我们苦想多年的而不可得答案的几个重大问题的根本。有您在，京南固安明天必将更好！
&&大师的话真如“大音希声扫阴翳”，犹如”拨开云雾见青天”，使我等网民看到了希望，看到了未来！晴天霹雳，醍醐灌顶或许不足以形容大师文章的万一；巫山行云，长江流水更难以比拟大师的文才！黄钟大吕，振聋发聩！你烛照天下，明见万里；雨露苍生，泽被万方！透过你深邃的文字，我仿佛看到了你鹰视狼顾，龙行虎步的伟岸英姿；仿佛看到了你手执如椽大笔，写天下文章的智慧神态；仿佛看见了你按剑四顾，江山无数的英武气概！
&&是你让偶幼小的心灵再次深深的领悟了何谓造旨之高深、文笔之挥洒。。谢谢you！
&&看完以后，我立即动手回复，因为我生怕迟到的回复不能使更多的人领悟你的圣明，以至使这等网上少有的好贴就此轮沉，我担不起这样的罪名！更加重要的是，能在如此重要、精辟而又生动的贴子后，留上自己的网名，这对我的生命，以及我的家庭，乃至我所处的社会中是多么荣耀的一件事啊，请您高贵而又宽容的心，能够原谅我的这点小小私心！
";
            var listData = dataStr.Split("&&");

            Random rd = new Random();
            var num = rd.Next(listData.Length - 1);

            return listData[num];
        }
    }
    public class PostInfo
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
    }
}
