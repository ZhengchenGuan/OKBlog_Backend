using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKBLOGAPI.Domain.Entities;

namespace OKBLOGAPI.Service.Interface
{
    public interface IRestaurantService
    {
        Task<IEnumerable<Restaurant>> GetAllAsync();
    }
}
