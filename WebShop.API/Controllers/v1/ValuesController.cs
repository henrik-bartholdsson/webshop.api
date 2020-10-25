using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebShop.API.Controllers.v1
{
    [Authorize]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public IActionResult GetValues()
        {
            var store = new string[] { "Hello World!", "Today is a good day", "The fall is finaly here", "Coding is fun", "Am I'm hungry?", "Awsome! :)" };

            var rnd = new Random();

            return Ok(new { Data = store[rnd.Next(0, store.Length)] });
        }
    }
}
