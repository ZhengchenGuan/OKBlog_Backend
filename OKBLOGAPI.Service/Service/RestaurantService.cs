using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKBLOGAPI.Domain.Entities;
using OKBLOGAPI.Service.Interface;

namespace OKBLOGAPI.Service.Service
{
    public class RestaurantService : IRestaurantService
    {
        public Task<IEnumerable<Restaurant>> GetAsync()
        {
            throw new NotImplementedException();
        }
    }
}
