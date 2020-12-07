using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebShop.API.Authenticate;

namespace WebShop.API.Controllers.v1
{
    [Authorize]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ValuesController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> GetValues()
        {


            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var store = new string[] { "Hello World!", "Today is a good day", "The fall is finaly here", "Coding is fun", "Am I'm hungry?", "Awsome! :)" };

            var rnd = new Random();

            return Ok(new { Data = user.Id + " - "  + store[rnd.Next(0, store.Length)] });
        }
    }
}
