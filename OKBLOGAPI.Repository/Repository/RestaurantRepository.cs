using OKBLOGAPI.Domain;
using OKBLOGAPI.Domain.Entities;
using OKBLOGAPI.Repository.Interface;

namespace OKBLOGAPI.Repository
{
    public class RestaurantRepository : RepositoryBase<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(OKBLOGContext context) : base(context)
        {
        }
    }
}