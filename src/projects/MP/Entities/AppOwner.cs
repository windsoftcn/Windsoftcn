using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Entities
{
    public class AppOwner : IEntityEnabled
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Remark { get; set; }

        public bool Enabled { get; set; }

        public ICollection<WxApp> WeChatApps { get; set; }
    }
}
