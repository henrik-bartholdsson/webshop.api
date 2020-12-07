using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebShop.API.Authenticate;
using WebShop.Contracts.v1.Requests;
using WebShop.Data.Models.Dto;
using WebShop.Service.v1;

namespace WebShop.API.Controllers.v1
{
    [Authorize]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IServiceV1 _service;
        private readonly UserManager<ApplicationUser> _userManager;

        public OrdersController(IServiceV1 orderService, UserManager<ApplicationUser> userManager)
        {
            _service = orderService;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult GetOrder(int id)
        {
            if (id == 0)
                return BadRequest("Id can not be 0 (zero)");

            try
            {
                var a = _service.GetOrder(id);
                return Ok(a);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] RequestOrderDto requestOrder)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            requestOrder.UserId = user.Id;
            OrderDto order;
            

            try
            {
                order = _service.CreateOrder(requestOrder);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(order);
        }

        // return Request.CreateResponse(HttpStatusCode.InternalServerError);

    }
}
