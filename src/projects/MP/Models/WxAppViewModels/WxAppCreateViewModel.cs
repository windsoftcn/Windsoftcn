using MP.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Models.WxAppViewModels
{
    public class WxAppCreateViewModel
    {
        public int Id { get; set; }

        public string AppId { get; set; }

        public string Secret { get; set; }

        public string AppName { get; set; }

        public string AppAlias { get; set; }

        public string Email { get; set; }

        public string IconUrl { get; set; }

        public string CoverUrl { get; set; }

        public string BannerUrl { get; set; }

        public string QRUrl { get; set; }

        public string ShareUrl { get; set; }

        public AppType AppType { get; set; }

        public string Tags { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Remark { get; set; }
    }
}
