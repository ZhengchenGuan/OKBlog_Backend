using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OKBLOGAPI.Service.Interface;
using OKBLOGAPI.Domain.Entities;

namespace OKBLOGAPI.Controllers
{
    [Route("restaurants")]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        [HttpGet("")]
        public async Task<IEnumerable<Restaurant>> GetAllAsync()
        {
            return await _restaurantService.GetAllAsync();
        }
    }
}
