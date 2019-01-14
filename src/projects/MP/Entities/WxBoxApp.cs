using MP.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Entities
{
    public class WxBoxApp : IEntityEnabled
    {
        public int Id { get; set; }
        public int Position { get; set; }
        public AppShowType AppShowType { get; set; }
        public AppNavigationType AppNavigationType { get; set; }
        public bool Enabled { get; set; }

        public int AppId { get; set; }
        public WxApp WxApp { get; set; }

        public int BoxId { get; set; }
        public WxBox WxBox { get; set; }
    }
}
