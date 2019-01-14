using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Entities
{
    public class WxBox
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Remark { get; set; }

        public ICollection<WxBoxApp> WxBoxApps { get; set; }
    }
}
