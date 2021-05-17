using OKBLOGAPI.Domain;
using OKBLOGAPI.Domain.Entities;

namespace OKBLOGAPI.Repository
{
    public class BookingRepository : RepositoryBase<Booking>
    {
        public BookingRepository(OKBLOGContext context) : base(context)
        {
        }
    }
}
