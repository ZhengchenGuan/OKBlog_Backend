using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKBLOGAPI.Domain.Entities;
using OKBLOGAPI.Repository.Interface;
using OKBLOGAPI.Service.Interface;

namespace OKBLOGAPI.Service.Service
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantService(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }
        public async Task<IEnumerable<Restaurant>> GetAllAsync()
        {
            return await _restaurantRepository.RetrieveAllAsync();
        }
    }
}
