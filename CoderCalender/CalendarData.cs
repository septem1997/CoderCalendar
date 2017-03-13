using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderCalender
{
    class CalendarData
    {
        public string Date { set; get; }
        public string AnimalConflict { set; get; }
        public ObservableCollection<Event> RecommendedEventList { set; get; }
        public ObservableCollection<Event> BanEventList { set; get; }
        public string Direction { set; get; }
        public string PrinceRate { set; get; }

        private static readonly string[] Directions = { "北方", "东北方", "东方", "东南方", "南方", "西南方", "西方", "西北方" };


        public CalendarData()
        {
            Date = "今天是" + DateTime.Today.ToString("yyyy年M月d日 dddd");

            RecommendedEventList = new ObservableCollection<Event>();
            BanEventList = new ObservableCollection<Event>();
            var hashSet = new HashSet<int>();
            var day = DateTime.Today - DateTime.Parse("1998-02-16");
            var num = day.Days*day.Days % 2020;
            var size = num % 4 + 3;

            var events = Event.Events.ToArray();

            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday || DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
            {
                var eventList =new List<Event>();
                eventList.AddRange(Event.Events.Where(e => e.IsWeekend));
                events = eventList.ToArray();
            }
            
            for (var i = 0; i < size; i++)
            {
                hashSet.Add(num % events.Length);
                num += num % 6 + 1;
                Debug.WriteLine("a");
            }
            

            foreach (var i in hashSet)
            {
                switch (events[i].Title)
                {
                    case "使用":
                        events[i].Title += Event.Tools[num % Event.Tools.Length];
                        break;
                    case "上班":
                        events[i].Title += Event.Things[num % Event.Things.Length];
                        break;
                    case "变量使用":
                        events[i].Title += Event.Rules[num % Event.Rules.Length];
                        break;
                    case "撩妹":
                        events[i].Title = Event.LiaoMei[num % Event.LiaoMei.Length];
                        break;
                    case "写超过":
                        events[i].Title += Event.Num[num % Event.Num.Length] + "行的方法";
                        break;
                    case "打":
                        events[i].Title += Event.Games[num % Event.Games.Length];
                        break;
                }
                if (num % 2 == 0)
                    RecommendedEventList.Add(events[i]);
                else
                    BanEventList.Add(events[i]);
                num++;
            }


            Direction = Directions[num % 8];
            PrinceRate = "女神亲近指数：";
            for (var i = 0; i < num % 5 + 1; i++)
            {
                PrinceRate += "★";
            }
            for (var i = num % 5 + 1; i < 5; i++)
            {
                PrinceRate += "☆";
            }
        }


    }
}
