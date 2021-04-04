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
        public async Task<IActionResult> GetOrders()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            try
            {
                var orders = _service.GetAllOrders(user.Id);
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetOrder(int id)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            try
            {
                var order = _service.GetOrder(id, user.Id);
                return Ok(order);
            }
            catch (Exception ex)
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
    }
}
