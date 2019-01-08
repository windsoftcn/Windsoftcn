using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using MP.Entities;
using MP.Extensions;
using MP.Models.WeChatAppsViewModels;
using MP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Controllers
{    
    [Authorize]
    public class WeChatAppController  : Controller
    {
        private readonly WeChatAppService appService;
        private readonly IMapper mapper;

        public WeChatAppController(WeChatAppService appService,
            IMapper mapper)
        { 
            this.appService = appService ?? throw new ArgumentNullException(nameof(appService));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
                    
        public async Task<IActionResult> Index()
        {
            var apps = await appService.GetAllAppsAsync();

            List<WeChatAppViewModel> appViewModels =  mapper.Map<List<WeChatApp>, List<WeChatAppViewModel>>(apps);

            return View(appViewModels);
        }

        
        [HttpGet]        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create([FromForm] WeChatAppCreateViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var weChatApp = mapper.Map<WeChatAppCreateViewModel, WeChatApp>(viewModel);
                await appService.CreateAppAsync(weChatApp);
                
                return Redirect(nameof(Index));
            }
            
            return View(viewModel);
        }

        [HttpGet("{id:int}")] 
        public async Task<IActionResult> Edit(int id)
        {
            var app = await appService.GetAppAsync(id);

            var appViewModel = mapper.Map<WeChatApp, WeChatAppViewModel>(app);

            return View(appViewModel);            
        }

        [HttpPost] 
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromForm] WeChatAppViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var weChatApp = mapper.Map<WeChatAppViewModel, WeChatApp>(viewModel);
                await appService.UpdateAppAsync(weChatApp);

                return Redirect(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        } 

        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var app = await appService.GetAppAsync(id);

            var appViewModel = mapper.Map<WeChatApp, WeChatAppViewModel>(app);

            return View(appViewModel);           
        }
    }
}
