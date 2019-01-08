using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MP.Entities;
using MP.Models;
using MP.Models.WeChatAppsViewModels;
using MP.Services;

namespace MP.Controllers
{
    public class HomeController : Controller
    {
        private readonly WeChatAppService appService;
        private readonly IMapper mapper;

        public HomeController(WeChatAppService appService,
            IMapper mapper)
        {
            this.appService = appService ?? throw new ArgumentNullException(nameof(appService));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IActionResult> Index()
        {
            var apps = await appService.GetAllAppsAsync();

            List<WeChatAppViewModel> appViewModels = mapper.Map<List<WeChatApp>, List<WeChatAppViewModel>>(apps);

            return View(appViewModels);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            //throw new Exception();
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
