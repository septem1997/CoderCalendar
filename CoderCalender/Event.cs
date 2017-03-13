using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderCalender
{
    class Event
    {
        public string Title { set; get; }
        public string Recommended { set; get; }
        public string Ban { set; get; }
        public bool IsWeekend { set; get; }

        

        public static Event[] Events = {
            new Event("写单元测试",  "写单元测试将减少出错", "写单元测试会降低你的开发效率",false),
            new Event("洗澡",  "你几天没洗澡了？", "会把设计方面的灵感洗掉", true),
            new Event("理发","你有几个月没剪头发了?","凌乱飘逸的头发让你看起来像个艺术家",true), 
            new Event("锻炼身体",  "改善你猥琐的气质", "能量没消耗多少，吃得却更多", true),
            new Event("抽烟",  "抽烟可以提神，增加思维敏捷", "除非你活够了，死得早点没关系", true),
            new Event("白天上线",  "今天白天上线是安全的", "可能导致灾难性后果",false),
            new Event("重构项目",  "代码质量得到提高", "你很有可能会陷入泥潭",false),
            new Event("使用",  "你看起来更有品位", "别人会觉得你在装逼",false),
            new Event("跳槽",  "该放手时就放手", "鉴于当前的经济形势，你的下一份工作未必比现在强",false),
            new Event("招人",  "会招到一名大牛带你装逼带你飞", "面试者都是从培训机构出来的",false),
            new Event("面试",  "面试官今天心情很好", "面试官不爽，会拿你出气",false),
            new Event("提交辞职申请",  "公司找到了一个比你更能干更便宜的家伙，巴不得你赶快滚蛋", "鉴于当前的经济形势，你的下一份工作未必比现在强",false),
            new Event("申请加薪",  "老板今天心情很好", "公司正在考虑裁员",false),
            new Event("晚上加班",  "晚上是程序员精神最好的时候", "身体会被掏空", true),
            new Event("在妹子面前装逼",  "可以改善你臭屌丝的形象", "会被揭穿并打脸", true),
            new Event("撩妹","妹子对你的好感大大提升","别逗了，程序员哪找得到女朋友",true), 
            new Event("撸管",  "避免缓冲区溢出", "强撸灰飞烟灭", true),
            new Event("逛1024",  "变得神清气爽", "你会心神不宁", true),
            new Event("写超过",  "你的代码组织的很好，长一点没关系", "你的代码将混乱不堪，你自己都看不懂",false),
            new Event("提交代码",  "遇到冲突的几率是最低的", "你遇到的一大堆冲突会让你觉得自己是不是时间穿越了",false),
            new Event("开会",  "写代码之余放松一下打个盹，有益健康", "小心被扣屎盆子背黑锅",false),
            new Event("打","你将有如神助", "你会被虐的很惨", true),
            new Event("晚上上线",  "晚上是程序员精神最好的时候", "你白天已经筋疲力尽了",false),
            new Event("修复BUG",  "你今天对BUG的嗅觉大大提高", "新产生的BUG将比修复的更多",false),
            new Event("设计评审",  "设计评审会议将变成头脑风暴", "人人筋疲力尽，评审就这么过了",false),
            new Event("Review代码",  "你会发现一些BUG", "什么问题都找不出来",false),
            new Event("上微博",  "今天发生的事不能错过", "今天的微博充满负能量", true),
            new Event("上知乎",  "可以发现更大的世界", "知乎上装逼的人太多了", true),
            new Event("上班","写代码之余放松一下有益身心健康","会被老板看到",false),
            new Event("写技术博客","你的知名度会大大提升","你写的东西无人问津",true),
            new Event("写开源项目","瞬间获得上千个Star","你写的代码都没人看",true),
            new Event("变量使用","你的代码不用写注释都很清晰","你都不知道你写了什么",false), 
            //new Event("泡图书馆","","");
        };


        public static readonly string[] LiaoMei = {"约会", "相亲", "撩妹"};
        public static readonly string[]  Tools = { "Vim写代码", "emacs写代码","记事本写代码", "Linux", "MacOS", "UWP应用"};
        public static readonly int[] Num = {64, 128, 256};
        public static readonly string[] Games = {"LOL", "DOTA", "守望先锋"};
        public static readonly string[] Rules = {"驼峰命名法", "拼音命名法", "匈牙利命名法","帕斯卡命名法" };
        public static readonly string[] Things = {"聊QQ", "聊微信", "刷朋友圈", "玩斗地主","玩扫雷"};
        private Event(string title, string recommended, string ban, bool isWeekend)
        {
            Title = title;
            Recommended = recommended;
            Ban = ban;
            IsWeekend = isWeekend;
        }
    }
}
