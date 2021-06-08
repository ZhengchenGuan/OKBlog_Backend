using OKBLOGAPI.Domain;
using OKBLOGAPI.Domain.Entities;
using OKBLOGAPI.Repository.Interface;

namespace OKBLOGAPI.Repository
{
    public class BookingRepository : RepositoryBase<Booking>, IBookingRepository
    {
        public BookingRepository(OKBLOGContext context) : base(context)
        {
        }
    }
}
