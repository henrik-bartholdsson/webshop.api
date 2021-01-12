using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;
using WebShop.API.Authenticate;

namespace WebShop.API.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _config;

        public ValuesController(UserManager<ApplicationUser> userManager, IConfiguration config)
        {
            _userManager = userManager;
            _config = config;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var store = new string[] { "Hello World!", "Today is a good day", "The fall is finaly here", "Coding is fun", "Am I'm hungry?", "Awsome! :)" };

            var rnd = new Random();

            return Ok(new { Data = user.Id + " - "  + store[rnd.Next(0, store.Length)] });
        }
    }
}
