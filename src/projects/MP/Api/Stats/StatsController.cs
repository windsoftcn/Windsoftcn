using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Api.Stats
{
    [Route("api/[controller]")]
    public class StatsController : RootController
    {
        public StatsController()
        {

        }

        [HttpGet("startup")]
        public async Task<IActionResult> Startup(string appId, string userId, string channelId)
        {
            // 添加到Redis 队列


            return Ok("success");
        }

        [HttpGet("test")]
        public IActionResult Test()
        {
            var message = new { Id = Guid.NewGuid(), Message = "test OK" };
            return Ok(message);
        }

        [HttpGet("error")]
        public IActionResult Error()
        {
            throw new ArgumentException();
        }
    }
}
