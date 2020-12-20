﻿using Microsoft.AspNetCore.Authorization;
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
        public async Task<IActionResult> GetOrder(int? id) // Kolla så att ordern tillhör den inlogade användaren
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            int orderId = 0;

            if (id != null)
            {
                orderId = (int)id;
                try
                {
                    var a = _service.GetOrder(orderId, user.Id); // Hämta specifik order
                    return Ok(a);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }

            try
            {
                var a = _service.GetAllOrders(user.Id); // Hämta alla ordrar
                return Ok(a);
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

        // return Request.CreateResponse(HttpStatusCode.InternalServerError);

    }
}