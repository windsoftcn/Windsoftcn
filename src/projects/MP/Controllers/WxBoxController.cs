using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MP.Entities;
using MP.Extensions;
using MP.Models.WxBoxViewModels;
using MP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Controllers
{
    [Authorize]
    public class WxBoxController: Controller
    {
        private readonly WxBoxService boxService;
        private readonly IMapper mapper;

        public WxBoxController(WxBoxService boxService,
            IMapper mapper)
        {
            this.boxService = boxService ?? throw new ArgumentNullException(nameof(boxService));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> BoxDetails(int boxId = 1)
        {
            var wxBox = await boxService.GetBoxDetailsAsync(boxId);

            if (wxBox.IsNull())
            {
                return NotFound();
            }

            var model = new BoxDetailViewModel
            {
                BoxId = wxBox.Id,
                BoxName = wxBox.Name,
                WxBoxApps = wxBox.WxBoxApps?.ToList()
            };

            return View(model);
        }




        [HttpPost]
        public async Task<IActionResult> AddBox([FromBody] WxBoxInputViewModel model)
        {
            if (ModelState.IsValid)
            {
                var box = mapper.Map<WxBoxInputViewModel, WxBox>(model);

                if (await boxService.AddBoxAsync(box) == 0)
                {
                    throw new InvalidOperationException("add box error.");
                }

                return Json(mapper.Map<WxBox, WxBoxViewModel>(box));
            }
            return BadRequest();            
        }
    }
}
