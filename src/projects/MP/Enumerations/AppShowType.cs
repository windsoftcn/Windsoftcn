using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Enumerations
{
    public class AppShowType : Enumeration
    {
        public static AppShowType 横幅 = new AppShowType(1, "横幅");

        public static AppShowType 小图标 = new AppShowType(2, "小图标");
         

        protected AppShowType(int id, string name) : base(id, name) { }      
    }

    public class AppNavigationType : Enumeration
    {
        public static AppNavigationType 直跳 = new AppNavigationType(1, "直跳");

        public static AppNavigationType 跳盒子 = new AppNavigationType(2, "跳盒子");

        public static AppNavigationType 二维码 = new AppNavigationType(3, "二维码");

        protected AppNavigationType(int id, string name) : base(id, name) { }
    }
}
