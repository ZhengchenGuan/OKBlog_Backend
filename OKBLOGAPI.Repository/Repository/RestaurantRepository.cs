using OKBLOGAPI.Domain;
using OKBLOGAPI.Domain.Entities;

namespace OKBLOGAPI.Repository
{
    public class RestaurantRepository : RepositoryBase<Restaurant>
    {
        public RestaurantRepository(OKBLOGContext context) : base(context)
        {
        }
    }
}