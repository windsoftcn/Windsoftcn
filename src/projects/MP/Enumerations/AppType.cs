using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Enumerations
{
    public class AppType :Enumeration
    {
        public static AppType 小程序 = new AppType(1, "小程序");

        public static AppType 小游戏 = new AppType(2, "小游戏");

        public static AppType 公众号 = new AppType(3, "公众号");

        protected AppType(int id, string name) : base(id, name) { }
        
    }
}
