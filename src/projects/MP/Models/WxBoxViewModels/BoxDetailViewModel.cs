using MP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Models.WxBoxViewModels
{
    public class BoxDetailViewModel
    {
        public int BoxId { get; set; }

        public string BoxName { get; set; }

        public List<WxBoxApp> WxBoxApps { get; set; }                
    }
}
