using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using MP.Entities;
using MP.Extensions;
using MP.Models.WxAppViewModels;
using MP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Controllers
{    
    [Authorize]
    public class WxAppController  : Controller
    {
        private readonly WxAppService appService;
        private readonly IMapper mapper;

        public WxAppController(WxAppService appService,
            IMapper mapper)
        { 
            this.appService = appService ?? throw new ArgumentNullException(nameof(appService));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
                    
        public async Task<IActionResult> Index()
        {
            var apps = await appService.GetAllAppsAsync(fromCache: false);

            List<WxAppViewModel> appViewModels =  mapper.Map<List<WxApp>, List<WxAppViewModel>>(apps);

            return View(appViewModels);
        }

        
        [HttpGet]        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create([FromForm] WxAppCreateViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var weChatApp = mapper.Map<WxAppCreateViewModel, WxApp>(viewModel);
                await appService.CreateAppAsync(weChatApp);
                
                return Redirect(nameof(Index));
            }
            
            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Edit([FromRoute] int? id)
        {
            if (id.IsNull())
                return NotFound();

            var app = await appService.GetAppAsync(id.Value);

            var appViewModel = mapper.Map<WxApp, WxAppViewModel>(app);

            return View(appViewModel);            
        }

        [HttpPost] 
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromForm] WxAppViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var weChatApp = mapper.Map<WxAppViewModel, WxApp>(viewModel);
                await appService.UpdateAppAsync(weChatApp);

                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        } 

        public async Task<IActionResult> Details(int? id)
        {
            if (id.IsNull())
                return NotFound();

            var app = await appService.GetAppAsync(id.Value);

            var appViewModel = mapper.Map<WxApp, WxAppViewModel>(app);

            return View(appViewModel);           
        }
    }
}
